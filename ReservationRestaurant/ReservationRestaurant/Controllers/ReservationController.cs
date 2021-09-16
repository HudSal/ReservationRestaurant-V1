﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReservationRestaurant.Data;
using ReservationRestaurant.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly PersonService _personService;
        private readonly UserManager<IdentityUser> _userManager;
        private IMapper _mapper;
        public ReservationController(ApplicationDbContext context, PersonService personService, UserManager<IdentityUser> userManager)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Reservation.Update, Data.Reservation>().ReverseMap().ForAllOtherMembers(x=>x.Ignore()));
            _mapper = new Mapper(config);
            _context = context;
            _personService = personService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var reservation = await _context.Reservations.Include(r => r.Person)
                                                       .Include(r => r.Sitting)
                                                       .ThenInclude(s => s.SittingType)
                                                       .Include(r => r.ReservationStatus)
                                                       .Include(r => r.ReservationOrigin)
                                                       .Include(r => r.Tables)
                                                       .OrderBy(r => r.Id).ToArrayAsync();
            return View(reservation);
        }

        [HttpGet]
        public async Task<IActionResult> Create(Models.Reservation.Create mo )
        {
            var m = new Models.Reservation.Create // here we create reservation model instance and assign default value for the guests
            {
                Guests = mo.Guests,
                StartTime = mo.StartTime,
                SittingTypeId = mo.SittingTypeId,
                SittingId = mo.SittingId
                //Sittings = new SelectList(_context.Sittings.ToArray(), nameof(Sitting.Id), nameof(Sitting.Name))
            };
            if (User.Identity.IsAuthenticated)// if the user has loged in
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                var person = await _context.People.FirstOrDefaultAsync(p => p.UserId == user.Id);
                if(person != null)
                {
                    m.PersonId = person.Id;// here we add rest of reservation model instance property to pass it to the view 
                    m.Email = person.Email;
                    m.FirstName = person.FirstName;
                    m.LastName = person.LastName;
                    m.PhoneNumber = person.Phone;
                }
            }
            return View(m);
        }

       
        [HttpPost]
        [ActionName("Create")]                                                  
        public async Task<IActionResult> CreateForm(Models.Reservation.Create m)
        {
            Person person = null;
            Reservation reservation = null;
            if (User.Identity.IsAuthenticated)// if the user has loged in and he is exist
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                person = await _context.People.FirstOrDefaultAsync(p => p.UserId == user.Id);
                ModelState.Remove("Email");// we remove these from the model to avoid the
                                           // errors when the user is exist the view page will show just the name and email as <p>
                                           // and just the guest will be as <input>, otherwise the inputs for email,forename,surname will be NULL and the Model will be Invalid
                                           // so we remove this condition from if condition"ModelState.IsValid)" 
                ModelState.Remove("FirstName");
                ModelState.Remove("LastName");
                ModelState.Remove("PhoneNumber");
            }
            person = await _context.People.FirstOrDefaultAsync(p => p.Email == m.Email);
            //if(person !=null && person.UserId == null)
            //{
            //    // add code advise they must log in // to avoid make a reservation from the same email with different forename
            //}
            if (ModelState.IsValid)
            {
                if (person == null)
                {
                    person = new Person
                    {
                        Email = m.Email,
                        FirstName = m.FirstName,
                        LastName = m.LastName,
                        Phone=m.PhoneNumber
                    };
                    person = await _personService.UpsertPersonAsync(person, false);
                }
                //create new reservation and assign the person id
                reservation = new Reservation
                {
                    PersonId = person.Id,
                    Guests = m.Guests,
                    StartTime = m.StartTime,
                    Duration = m.Duration,
                    ReservationStatusId = m.ReservationStatusId,
                    ReservationOriginId = m.ReservationOriginId,
                    SittingId=m.SittingId
                };
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();
                // we can put here the RedirectToAction Details is better and out of if condition when the form is Unvalid return Error Page
                //return RedirectToAction(nameof(Details), new { reservation.Id });
            }
            if (!ModelState.IsValid)
            {
                var myerrors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.Exception));

                // Breakpoint, Log or examine the list with Exceptions.

            }
            var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => new { x.Key, x.Value.Errors })
                        .ToArray();
            return RedirectToAction(nameof(Details), new { reservation.Id });
        }

                                                  
        public async Task<ActionResult> Details(int? id)
        {

            try
            {
                if (!id.HasValue)
                {
                    return StatusCode(400, "Id required");
                }
                var reservation = await _context.Reservations.Include(r => r.Person)
                                                              .Include(r => r.Sitting)
                                                              .ThenInclude(s => s.SittingType)
                                                              .Include(r => r.ReservationStatus)
                                                              .Include(r => r.ReservationOrigin)
                                                              .FirstOrDefaultAsync(r => r.Id == id.Value);
                if (reservation == null)
                {
                    return NotFound();
                }
                return View(reservation);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        ////To display All the reservation history for the user who reserve using the same email
        [Authorize(Roles = "Member")]
        public async Task<ActionResult> History()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var person = await _context.People.FirstOrDefaultAsync(p => p.UserId == user.Id);
            var reservations = await _context.Reservations.Include(r => r.Person).Where(r => r.PersonId == person.Id)
                                                          .Include(r => r.Sitting)
                                                          .Include(r => r.ReservationStatus).ToListAsync();
            return View(reservations);
        }


        [HttpGet]
        public async Task<IActionResult> PreCreate()
        {
            var sittingList = await _context.Sittings.Include(x => x.SittingType).ToListAsync();
            var sittingType = await _context.SittingTypes.ToListAsync();

            var today = DateTime.Now;

            var maxDate = sittingList.Select(x => x.StartTime).Max(); //the latest day in the sittingList

            int dateDifference = (int)(maxDate - today).TotalDays; // how many days between today and last day of available sitting

            string maximumBookingDate = "+" + (dateDifference.ToString()) + "d"; // to get format +2d or +3d or +4d that I need to use for datepicker jquery


            Models.Reservation.PreCreate preCreate = new Models.Reservation.PreCreate()
            {
                SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name)),
                AmountOfDaysForCalendar = maximumBookingDate
            };

            return View(preCreate);
        }

        [HttpPost]
        public async Task<IActionResult> PreCreate(Models.Reservation.PreCreate preCreate)
        {
            DateTime dateSelected = DateTime.Parse(preCreate.StartTime);


            var allSitting = await _context.Sittings.Include(x => x.SittingType).Include(x=>x.Reservations).ToListAsync();  //first get a list of all the available sittings

            //this returns particular sitting that the customer had chosen, based on the date and sittingType (bfast,lunch, etc)
            var selectedSitting = allSitting.FirstOrDefault(x => x.StartTime.Day == dateSelected.Day && x.SittingTypeId == preCreate.SittingTypeId);
            if (selectedSitting == null)
            {
                preCreate.SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
                preCreate.Message = "The selected day has no particular sittings";
                return View(preCreate);
            }
            if (selectedSitting.IsClosed == true || selectedSitting.Vacancies < preCreate.Guests)
            {
                preCreate.SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
                preCreate.Message = "The selected sitting is full";
                return View(preCreate);
            }
            var create = new Models.Reservation.Create()
            {
                StartTime = dateSelected,
                Guests = preCreate.Guests,
                SittingTypeId = preCreate.SittingTypeId,
                SittingId=selectedSitting.Id,
                SittingType= selectedSitting.SittingType
            };

            return RedirectToAction(nameof(Create), create);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }
            var reservation = await _context.Reservations.Include(r => r.Person)
                                                              .Include(r => r.Sitting)
                                                              .ThenInclude(s => s.SittingType)
                                                              .Include(r => r.ReservationStatus)
                                                              .Include(r => r.ReservationOrigin)
                                                              .Include(r=>r.Tables)
                                                              .FirstOrDefaultAsync(r => r.Id == id.Value);
            if (reservation == null)
            {
                return NotFound();
            }
            var m = _mapper.Map<Models.Reservation.Update>(reservation);
            m.Tables = new SelectList(_context.Tables.ToArray(), nameof(Table.Id), nameof(Table.Name), m.TableId);
            m.SittingTypes = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name),m.SittingTypeId);
            m.ReservationStatuses = new SelectList(_context.ReservationStatuses.ToArray(), nameof(ReservationStatus.Id), nameof(ReservationStatus.Name), m.ReservationStatusId);
            m.ReservationOrigins = new SelectList(_context.ReservationOrigins.ToArray(), nameof(ReservationOrigin.Id), nameof(ReservationOrigin.Name), m.ReservationOriginId);
            m.Sittings = new SelectList(_context.Sittings.ToArray(), nameof(Sitting.Id), nameof(Sitting.Name), m.SittingId);
            return View(m);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Models.Reservation.Update m)
        {
            if (id != m.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var r = _mapper.Map<Data.Reservation>(m);
                    _context.Update<Reservation>(r);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Details));
                }
                catch (Exception ex)
                {
                    //log the exception

                }
            }
            m.Tables = new SelectList(_context.Tables.ToArray(), nameof(Table.Id), nameof(Table.Name), m.TableId);
            m.SittingTypes = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name), m.SittingTypeId);
            m.ReservationStatuses = new SelectList(_context.ReservationStatuses.ToArray(), nameof(ReservationStatus.Id), nameof(ReservationStatus.Name), m.ReservationStatusId);
            m.ReservationOrigins = new SelectList(_context.ReservationOrigins.ToArray(), nameof(ReservationOrigin.Id), nameof(ReservationOrigin.Name), m.ReservationOriginId);
            m.Sittings = new SelectList(_context.Sittings.ToArray(), nameof(Sitting.Id), nameof(Sitting.Name), m.SittingId);
            return View(m);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return StatusCode(400, "Id required");
                }
                var reservation = await _context.Reservations.Include(r => r.Person)
                                                              .Include(r => r.Sitting)
                                                              .ThenInclude(s => s.SittingType)
                                                              .Include(r => r.ReservationStatus)
                                                              .Include(r => r.ReservationOrigin)
                                                              .Include(r => r.Tables)
                                                              .FirstOrDefaultAsync(r => r.Id == id.Value);
                if (reservation == null)
                {
                    return NotFound();
                }
                return View(reservation);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return StatusCode(400, "Id required");
                }
                var reservation = await _context.Reservations.Include(r => r.Person)
                                                              .Include(r => r.Sitting)
                                                              .ThenInclude(s => s.SittingType)
                                                              .Include(r => r.ReservationStatus)
                                                              .Include(r => r.ReservationOrigin)
                                                              .Include(r => r.Tables)
                                                              .FirstOrDefaultAsync(r => r.Id == id.Value);
                if (reservation == null)
                {
                    return NotFound();
                }
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                //log the exp
            }
            return RedirectToAction("Delete", new { id });
        }

    }
}

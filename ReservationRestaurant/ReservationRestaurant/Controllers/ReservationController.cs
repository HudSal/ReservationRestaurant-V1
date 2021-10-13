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
        public async Task<IActionResult> Index(string searchString, string option, string sortOrder)
        {
            var reservation = await _context.Reservations.Include(r => r.Person)
                                                       .Include(r => r.Sitting)
                                                       .ThenInclude(s => s.SittingType)
                                                       .Include(r => r.ReservationStatus)
                                                       .Include(r => r.ReservationOrigin)
                                                       .Include(r => r.Tables)
                                                       .OrderBy(r => r.Id).ToArrayAsync();


            ViewData["CurrentFilter"] = searchString;



            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
            ViewBag.DateSortParm = String.IsNullOrEmpty(sortOrder) ? "Date" : "Date";
            ViewBag.TypeSortParm = String.IsNullOrEmpty(sortOrder) ? "Sitting" : "Sitting";


            switch (sortOrder)
            {
                case "Name":
                    reservation = reservation.OrderBy(s => s.Person.LastName).ToArray();
                    break;
                case "Date":
                    reservation = reservation.OrderBy(s => s.StartTime).ToArray();
                    break;
                case "Sitting":
                    reservation = reservation.OrderBy(s => s.Sitting.SittingTypeId).ToArray();
                    break;
                default:
                    reservation = reservation.OrderBy(s => s.Id).ToArray();
                    break;
            }


            if (!String.IsNullOrEmpty(searchString))
            {
                if (option == "Name")
                {
                    reservation = reservation.Where(s => s.Person.LastName.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToArray();
                }

                else if (option == "Email")
                {
                    reservation = reservation.Where(s => s.Person.Email.Contains(searchString)).ToArray();
                }

                else if (option == "ReservationId")
                {
                    reservation = reservation.Where(s => s.Id == int.Parse(searchString)).ToArray();
                }
                else
                {
                    return View(reservation);
                }

            }


            return View(reservation);
        }
        
        [HttpGet]
        public async Task<IActionResult> PreCreate()
        {
            var sittingList = await _context.Sittings.Include(x => x.SittingType).ToListAsync();
            var sittingType = await _context.SittingTypes.ToListAsync();

            var today = DateTime.Now;

            var maxDate = sittingList.Select(x => x.StartTime).Max(); //the latest day in the sittingList

            int dateDifference = (int)(maxDate - today).TotalDays-2; // how many days between today and last day of available sitting
            // minus two because they way DateTime count days includes the starting day (between today and tomo = 2 days)

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
            if (ModelState.IsValid)
            {
                DateTime dateSelected = DateTime.Parse(preCreate.StartTime);


                var allSitting = await _context.Sittings.Include(x => x.SittingType).Include(x => x.Reservations).ToListAsync();  //first get a list of all the available sittings

                if(preCreate.Guests < 1)
                {
                    preCreate.SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
                    preCreate.Message = $"The number of guest has to be bigger than 1";
                    return View(preCreate);
                }

                //this returns particular sitting that the customer had chosen, based on the date and sittingType (bfast,lunch, etc)
                var selectedSitting = allSitting.FirstOrDefault(x => x.StartTime.Day == dateSelected.Day && x.SittingTypeId == preCreate.SittingTypeId);
                if (selectedSitting == null)
                {
                    preCreate.SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
                    preCreate.Message = $"The selected day ({dateSelected.ToShortDateString()}) doesn't have that particular sittings. " +
                        "Please contact the restaurant to check if we can accommodate your request";
                    return View(preCreate);
                }
                if (selectedSitting.IsClosed == true || selectedSitting.Vacancies < preCreate.Guests)
                {
                    preCreate.SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
                    preCreate.Message = $"The sitting ({selectedSitting.SittingType.Name}) for selected day is full. " +
                        "Please contact the restaurant to check if we can accommodate your request";
                    return View(preCreate);
                }
                var create = new Models.Reservation.Create()
                {
                    StartTime = preCreate.StartTime,
                    Guests = preCreate.Guests,
                    SittingTypeId = preCreate.SittingTypeId,
                    SittingId = selectedSitting.Id,
                    SittingType = selectedSitting.SittingType
                };

                return RedirectToAction(nameof(Create), create); 
            }

            var today = DateTime.Now;
            var sittingList = await _context.Sittings.Include(x => x.SittingType).ToListAsync();
            var maxDate = sittingList.Select(x => x.StartTime).Max(); //the latest day in the sittingList
            int dateDifference = (int)(maxDate - today).TotalDays - 2; // how many days between today and last day of available sitting
            // minus two because they way DateTime count days includes the starting day (between today and tomo = 2 days)
            string maximumBookingDate = "+" + (dateDifference.ToString()) + "d"; // to get format +2d or +3d or +4d that I need to use for datepicker jquery


            preCreate.SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
            preCreate.AmountOfDaysForCalendar = maximumBookingDate;
            

            return View(preCreate);

        }

        [HttpGet]
        public async Task<IActionResult> Create(Models.Reservation.Create mo )
        {  
         var allTimeSlots = await _context.TimeSlots.ToArrayAsync();
            List<TimeSlot> timeSlotsOfSittingType = new List<TimeSlot>();
            foreach (var item in allTimeSlots)
            {
                if (item.SittingTypeId == mo.SittingTypeId)
                {
                    timeSlotsOfSittingType.Add(item);
                }
            }
            var m = new Models.Reservation.Create // here we create reservation model instance and assign default value for the guests
            {
                Guests = mo.Guests,
                StartTime = mo.StartTime,
                SittingTypeId = mo.SittingTypeId,
                SittingId = mo.SittingId,
                TimeSL= new SelectList(timeSlotsOfSittingType,nameof(TimeSlot.Id),nameof(TimeSlot.Time))
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
            Reservation reservation = null;
            var person = await _context.People.FirstOrDefaultAsync(p => p.Email == m.Email);
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
                string selectedDate = m.StartTime; //selectedDate as astring
                var selectedTimeSlot = await _context.TimeSlots.FirstOrDefaultAsync(t => t.Id == m.TimeSlotID);
                string selectedTime = selectedTimeSlot.Time;//get the time portion of the timeslot - still a string at this stage
                string cobineDateTime = selectedDate + " " + selectedTime;// concat the date and time
                DateTime finalDateTime = DateTime.Parse(cobineDateTime); // convert it to DateTime object
                
                //create new reservation and assign the person id
                reservation = new Reservation
                {
                    PersonId = person.Id,
                    Guests = m.Guests,
                    StartTime = finalDateTime,
                    Duration = m.Duration,
                    ReservationStatusId = m.ReservationStatusId,
                    ReservationOriginId = m.ReservationOriginId,
                    SittingId=m.SittingId,
                    SpecialRequirement=m.SpecialRequirement
                };
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { reservation.Id });
            }
            if (!ModelState.IsValid)
            {
                var myerrors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.Exception));
                // Breakpoint, Log or examine the list with Exceptions.
                var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => new { x.Key, x.Value.Errors })
                        .ToArray();
            } 
            return View(m);
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
                                                              .Include(r=>r.Tables)
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
        
        //public async Task<IActionResult> Search(string option, string search)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(search))
        //        {
        //            return StatusCode(400, "Search Input is required, can not be empty");
        //        }
        //        if (string.IsNullOrEmpty(option))
        //        {
        //            return StatusCode(400, "Option Input is required, can not be empty");
        //        }
        //        if (option == "ReservationId")
        //        {
        //            int resrvationId = int.Parse(search);
        //            var reservation = await _context.Reservations.Include(r => r.Person)
        //                                                              .Include(r => r.Sitting)
        //                                                              .ThenInclude(s => s.SittingType)
        //                                                              .Include(r => r.ReservationStatus)
        //                                                              .Include(r => r.ReservationOrigin)
        //                                                              .Include(r => r.Tables)
        //                                                              .FirstOrDefaultAsync(r => r.Id == resrvationId);
        //            if (reservation == null)
        //            {
        //                return NotFound();
        //            }
        //            return RedirectToAction(nameof(Details), new { reservation.Id });
        //        }
        //        else if (option == "Email")
        //        {
        //            var person = await _context.People.FirstOrDefaultAsync(p => p.Email == search.Trim().ToLower());
        //            if (person == null)
        //            {
        //                return NotFound();
        //            }
        //            return RedirectToAction(nameof(History), new { person.Id });
        //        }
        //        else if (option == "Name")
        //        {
        //            var person = await _context.People.FirstOrDefaultAsync(p => p.FirstName == search.Trim());
        //            if (person == null)
        //            {
        //                return NotFound();
        //            }
        //            return RedirectToAction(nameof(History), new { person.Id });
        //        }
        //        else
        //        {
        //            return StatusCode(400, "Option Or Search Input is required, can not be empty");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500);
        //    }
        //}

        [Authorize(Roles = "Member")]
        public async Task<ActionResult> History(int? id)
        {
            List<Reservation> reservations = null;
            if (id.HasValue)//I want to view the reservation list for someone from the PersonDetails view
            {
                var person = await _context.People.Include(p => p.Reservations).FirstOrDefaultAsync(p => p.Id == id.Value);
                if (person == null)
                {
                    return NotFound();
                }
                reservations = await _context.Reservations.Include(r => r.Person).Where(r => r.PersonId == person.Id)
                                                            .Include(r => r.Sitting)
                                                            .ThenInclude(s => s.SittingType)
                                                            .Include(r => r.ReservationStatus)
                                                            .Include(r => r.ReservationOrigin)
                                                            .Include(r => r.Tables)
                                                            .ToListAsync();
            }
            else // I want to check my reservation list (who is register and using this service) 
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                var person = await _context.People.FirstOrDefaultAsync(p => p.UserId == user.Id);
                reservations = await _context.Reservations.Include(r => r.Person).Where(r => r.PersonId == person.Id)
                                                            .Include(r => r.Sitting)
                                                            .ThenInclude(s => s.SittingType)
                                                            .Include(r => r.ReservationStatus)
                                                            .Include(r => r.ReservationOrigin)
                                                            .Include(r => r.Tables)
                                                            .ToListAsync();
            }
            return View(reservations);
        }
  
        
        [Authorize(Roles = "Member")]
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }
            var reservation = await _context.Reservations.Include(r => r.Person)
                                                              .Include(r => r.Sitting)
                                                              .ThenInclude(s => s.SittingType).ThenInclude(s => s.TimeSlots)
                                                              .Include(r => r.ReservationStatus)
                                                              .Include(r => r.ReservationOrigin)
                                                              .Include(r=>r.Tables)
                                                              .FirstOrDefaultAsync(r => r.Id == id.Value);
            if (reservation == null)
            {
                return NotFound();
            }
            var startDate = reservation.StartTime.ToString("dd/MM/yyyy");// to get the reservation date only as string
            var startTime= reservation.StartTime.ToString("h:mm tt");// to get the reservation Time only as string
            var selectedTimeDB = await _context.TimeSlots.FirstOrDefaultAsync(t => t.Time == startTime);
            var m = new Models.Reservation.Update // here we  create update reservation model instance
            {
                Id= reservation.Id,
                PersonId= reservation.PersonId,
                FirstName = reservation.Person.FirstName,
                LastName = reservation.Person.LastName,
                Email = reservation.Person.Email,
                PhoneNumber = reservation.Person.Phone,
                StartTime = startDate,
                TimeSlot= selectedTimeDB,
                Guests = reservation.Guests,
                SpecialRequirement = reservation.SpecialRequirement,
                Duration = reservation.Duration,
                ReservationStatusId = reservation.ReservationStatusId,
                ReservationOriginId = reservation.ReservationOriginId,
                SittingId = reservation.SittingId,
                Sitting = reservation.Sitting,
                ExistingTables = reservation.Tables,
                ReservationStartDateTime=reservation.StartTime
            };
            var allTables = await _context.Tables.ToListAsync();
            foreach (var table in allTables)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text =table.Name,
                    Value = table.Id.ToString(),
                };
                m.Tables.Add(selectListItem);
            }
            foreach (var tId in m.ExistingTables)
            {
                m.SelectedTablesIds.Add(tId.Id);
            }
            m.ReservationStatuses = new SelectList(_context.ReservationStatuses.ToArray(), nameof(ReservationStatus.Id), nameof(ReservationStatus.Name), m.ReservationStatusId);
            m.ReservationOrigins = new SelectList(_context.ReservationOrigins.ToArray(), nameof(ReservationOrigin.Id), nameof(ReservationOrigin.Name), m.ReservationOriginId);
            return View(m);
        }

        [Authorize(Roles = "Member")]
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
                    var reservation = await _context.Reservations.Include(r => r.Person)
                                                        .Include(r => r.Sitting)
                                                        .Include(r => r.ReservationStatus)
                                                        .Include(r => r.ReservationOrigin)
                                                        .Include(r => r.Tables)
                                                        .FirstOrDefaultAsync(r => r.Id == id);
                    if (reservation.Tables.Count != 0 && m.SelectedTablesIds.Count != 0)
                    {
                        reservation.Tables.Clear();
                        _context.Reservations.Update(reservation);
                        await _context.SaveChangesAsync();
                    }
                    if (m.SelectedTablesIds.Count != 0)
                    {
                        List<int> result = m.SelectedTablesIds;//here you could get the selected Tables Id's
                        List<Table> selectedTables = new List<Table>();
                        foreach (var tId in result)
                        {
                            var tableSelcted = await _context.Tables.FirstOrDefaultAsync(t => t.Id == tId);
                            selectedTables.Add(tableSelcted);
                        }
                        reservation.Tables.AddRange(selectedTables);
                     }
                    reservation.Id = m.Id;
                    reservation.PersonId = m.PersonId;
                    reservation.Guests = m.Guests;
                    reservation.StartTime = m.ReservationStartDateTime;
                    reservation.Duration = m.Duration;
                    reservation.ReservationStatusId = m.ReservationStatusId;
                    reservation.ReservationOriginId = m.ReservationOriginId;
                    reservation.SittingId = m.SittingId;
                    reservation.SpecialRequirement = m.SpecialRequirement;
                    _context.Reservations.Update(reservation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Details), new { reservation.Id });
                }
                catch (Exception ex)
                {
                     return NotFound(ex);
                }
            }
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                  .Where(x => x.Value.Errors.Count > 0)
                  .Select(x => new { x.Key, x.Value.Errors })
                  .ToArray();
            }
            var allTables = await _context.Tables.ToListAsync();
            foreach (var table in allTables)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = table.Name,
                    Value = table.Id.ToString()
                };
                m.Tables.Add(selectListItem);
            }
            m.ReservationStatuses = new SelectList(_context.ReservationStatuses.ToArray(), nameof(ReservationStatus.Id), nameof(ReservationStatus.Name), m.ReservationStatusId);
            m.ReservationOrigins = new SelectList(_context.ReservationOrigins.ToArray(), nameof(ReservationOrigin.Id), nameof(ReservationOrigin.Name), m.ReservationOriginId);
            m.Sitting = await _context.Sittings.Include(s => s.SittingType).FirstOrDefaultAsync(s => s.Id == m.SittingId);
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

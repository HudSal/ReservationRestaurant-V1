﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReservationRestaurant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Areas.Admin.Controllers
{
    [Authorize(Roles = "Manager")]
    public class SittingController : AdminAreaBaseController
    {
        //private Mapper _mapper;//I added this
        public SittingController(ApplicationDbContext context) : base(context)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Sitting.Update, Data.Sitting>().ReverseMap());
            _mapper = new Mapper(config);
        }
    
        public IActionResult Index(string sortOrder)
        {
            var listOfSittings = _context.Sittings.Include(x => x.SittingType).Include(x => x.Restaurant).ToList();
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            ViewBag.DateSortParm = String.IsNullOrEmpty(sortOrder) ? "Date" : "";
            ViewBag.TypeSortParm = String.IsNullOrEmpty(sortOrder) ? "Sitting" : "";
            ViewBag.BoolSortParm = String.IsNullOrEmpty(sortOrder) ? "Bool" : "";

            switch (sortOrder)
            {
                case "Name":
                    listOfSittings = listOfSittings.OrderBy(s => s.Name).ToList();
                    break;
                case "Date":
                    listOfSittings = listOfSittings.OrderBy(s => s.StartTime).ToList();
                    break;
                case "Sitting":
                    listOfSittings = listOfSittings.OrderBy(s => s.SittingTypeId).ToList();
                    break;
                case "Bool":
                    listOfSittings = listOfSittings.OrderBy(s => s.IsClosed).ToList();
                    break;
                default:
                    listOfSittings = listOfSittings.OrderBy(s => s.StartTime).ToList();
                    break;
            }
            
            return View(listOfSittings);

        }

     
        [HttpGet]
        public IActionResult Create()
        {
            var pseudoSittingCreate = new Models.Sitting.Create
            {
                SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name))
            };

            return View(pseudoSittingCreate);
        }


        [HttpPost]
        public IActionResult Create(Models.Sitting.Create psc)
        {
            for (int i = 0; i < psc.Amount; i++)
            {
                Sitting stg = new Sitting
                {
                    StartTime = psc.StartTime.AddDays(i),
                    EndTime = psc.EndTime.AddDays(i),
                    SittingTypeId = psc.SittingTypeId,
                    Capacity = psc.Capacity,
                    RestaurantId = 1,
                    Name = psc.Name
                };
                _context.Sittings.Add(stg);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

 
        [HttpGet]
        public IActionResult Update(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return StatusCode(400, "Id not found");
                }
                var sitting = _context.Sittings.Include(x => x.SittingType).FirstOrDefault(x => x.Id == id);
                if (id == null)
                {
                    return NotFound();
                }
                var sittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
                var psu = _mapper.Map<Models.Sitting.Update>(sitting);
                psu.SittingTypeSL = sittingTypeSL;
                return View(psu);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        
        [HttpPost]
        public IActionResult Update(int? id, Models.Sitting.Update psu)
        {
            if (id != psu.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    Sitting sitting = _mapper.Map<Data.Sitting>(psu);
                    sitting.RestaurantId = 1;

                    _context.Sittings.Update(sitting);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }
            }
            psu.SittingTypeSL = new SelectList(_context.SittingTypes.ToArray(), nameof(SittingType.Id), nameof(SittingType.Name));
            return View(psu);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return StatusCode(400, "Id not found");
                }
                var sitting = _context.Sittings.Include(x => x.SittingType).Include(x => x.Reservations)
                                                                            .Include(s=>s.Restaurant)
                                                                            .FirstOrDefault(x => x.Id == id);
                if (id == null)
                {
                    return NotFound();
                }
                return View(sitting);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int? id, Sitting sitting)
        {
            if (id != sitting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (!id.HasValue)
                    {
                        return StatusCode(400, "Id not found");
                    }
                    if (id == null)
                    {
                        return NotFound();
                    }
                    //var reservations = await _context.Reservations.Include(r => r.Sitting).Where(r => r.SittingId == sitting.Id)
                    //                                     .Include(r => r.Person)
                    //                                     .Include(r => r.ReservationStatus).ToListAsync();
                    //var sittingList = await _context.Sittings.Include(s => s.Reservations).Where(s => s.Id == sitting.Id)
                    //                                        .ToListAsync();// the sitting which I want to delete including all the reservation which is belong to this sitting

                    var sittingList = await _context.Sittings.Include(s => s.Reservations).FirstOrDefaultAsync(s => s.Id == sitting.Id);
                                                          

                    //var reservationList = sitting.Reservations.ToList();//I Add this
                    _context.Sittings.Remove(sittingList);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {


                }

                return RedirectToAction("Delete", new { id });
            }
            return StatusCode(500);
        }

        public IActionResult Details(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return StatusCode(400, "Id not found");
                }
                var sitting = _context.Sittings.Include(x => x.SittingType).Include(x => x.Restaurant).Include(s=>s.Reservations).FirstOrDefault(x => x.Id == id);
                if (id == null)
                {
                    return NotFound();
                }
                return View(sitting);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        public IActionResult ReservationList(int? id)
        {
            //Here we have to include the reservationStatus , ReservationRegion and Person which are in the ReservationList to make it visable in the view
            // Or Can we pass it as ViewwBag or ViewData
            var sitting = _context.Sittings.Include(s => s.SittingType)
                                            .Include(s => s.Reservations).ThenInclude(r=>r.ReservationStatus)
                                            .Include(s => s.Reservations).ThenInclude(r => r.ReservationOrigin)
                                            .Include(s => s.Reservations).ThenInclude(r => r.Person)
                                            .Include(s => s.Restaurant)
                                            .FirstOrDefault(s => s.Id == id);
            //var sitting = _context.Sittings.Include(x => x.Reservations)
            //                                .FirstOrDefault(x => x.Id == id);
            var reservationList = sitting.Reservations.ToList();
            return View(sitting);
        }
    }
}

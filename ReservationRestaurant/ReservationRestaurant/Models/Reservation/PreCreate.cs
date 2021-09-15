using Microsoft.AspNetCore.Mvc.Rendering;
using ReservationRestaurant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Models.Reservation
{
    public class PreCreate
    {

        public string StartTime { get; set; }
        public int Guests { get; set; }

        public SelectList SittingTypeSL { get; set; }

        public int SittingTypeId { get; set; }
        public SittingType SittingType { get; set; }

        public string Message { get; set; }

        public string AmountOfDaysForCalendar { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc.Rendering;
using ReservationRestaurant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Models.Reservation
{
    public class PreCreate
    {
        [Display(Name ="Date")]
        public string StartTime { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} must be at least {1}.")]
        public int Guests { get; set; }

        public SelectList SittingTypeSL { get; set; }
        [Display(Name = "Sitting")]
        public int SittingTypeId { get; set; }
        public SittingType SittingType { get; set; }

        public string Message { get; set; }

        public string AmountOfDaysForCalendar { get; set; }
    }
}

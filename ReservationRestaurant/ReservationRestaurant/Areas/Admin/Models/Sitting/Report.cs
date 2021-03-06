using ReservationRestaurant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Areas.Admin.Models.Sitting
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Capacity { get; set; }
        public SittingType SittingType { get; set;  }

        public int ReservationCount { get; set; }
        [Display(Name = "Number of vanancies")]
        public int Vacanies { get; set;  }
        [Display(Name = "Total people in sitting")]
        public int pax { get; set; }
        [Display(Name = "Number of tables reserved")]
        public int Tables { get; set; }     
        [Display(Name = "Number of Bookings by Phone")]
        public int NumberOfPhoneBookings { get; set; }
        [Display(Name = "Number of Bookings by Email")]
        public int NumberOfEmailBookings { get; set; }
        [Display(Name = "Number of Bookings Online")]
        public int NumberOfOnlineBookings { get; set; }
        [Display(Name = "Number of Walk in Bookings")]
        public int NumberOfWalkInBookings { get; set; }
    }
}

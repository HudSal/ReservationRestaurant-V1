using Microsoft.AspNetCore.Mvc.Rendering;
using ReservationRestaurant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Models.Reservation
{
    public class Create
    {
        public String StartTime { get; set; }/* = DateTime.Now;*/
        public int Guests { get; set; } = 2;// default value = 2
        [Required(ErrorMessage = "Person - FirstName: Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Person - LastName: Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Person - Email: Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Person - PhoneNumber: Required")]
        public string PhoneNumber { get; set; }
        public int PersonId { get; set; }
        public string SpecialRequirement { get; set; } = "";
        [Display(Name = "Duration Time in minutes")]
        public int Duration { get; set; } = 90;
        [Display(Name = "Sitting Name")]
        [Required(ErrorMessage = "Rservation - Sitting Type: Required")]
        public int SittingId { get; set; }
        public int ReservationOriginId { get; set; } = 3;// id=3 --> Online
        public int ReservationStatusId { get; set; } = 1;// id=1 --> Pending
        public int SittingTypeId { get; set; }
        public SittingType SittingType { get; set; }
        public SelectList TimeSL { get; set; }
        public int TimeSlotID { get; set; }
        public TimeSlot TimeSlot { get; set; }
        

    }
}
e

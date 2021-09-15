using Microsoft.AspNetCore.Mvc.Rendering;
using ReservationRestaurant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Models.Reservation
{
    public class Update: Models.Reservation.Create
    {
        [Required]
        public int Id { get; set; }
        public int TableId { get; set; }
        public SelectList Tables { get; set; }
        //public int SittingTypeSLId { get; set; }
        public SelectList SittingTypes { get; set; }
        public SelectList ReservationStatuses { get; set; }
        public SelectList ReservationOrigins { get; set; }
        public SelectList Sittings { get; set; }
    }
}

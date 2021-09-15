using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationRestaurant.Data
{
    public class DataSeeder
    {
        //DataSeeding
        public DataSeeder(ModelBuilder mb)
        {
            mb.Entity<Restaurant>()
                .HasData(new Restaurant { Id = 1, Name = "Bean Scene", Address="69 Bean Street", PhoneNumber="04 8888 9999" });

            mb.Entity<Area>()
                .HasData(
                new Area { Id = 1, RestaurantId = 1, Name = "Main" },
                new Area { Id = 2, RestaurantId = 1, Name = "Outside" },
                new Area { Id = 3, RestaurantId = 1, Name = "Balcony" }
                );
            mb.Entity<Table>()
                .HasData(
                new Table { Id = 1, AreaId = 1, Name = "M1" },
                new Table { Id = 2, AreaId = 1, Name = "M2" },
                new Table { Id = 3, AreaId = 1, Name = "M3" },
                new Table { Id = 4, AreaId = 1, Name = "M4" },
                new Table { Id = 5, AreaId = 1, Name = "M5" },
                new Table { Id = 6, AreaId = 1, Name = "M6" },
                new Table { Id = 7, AreaId = 1, Name = "M7" },
                new Table { Id = 8, AreaId = 1, Name = "M8" },
                new Table { Id = 9, AreaId = 1, Name = "M9" },
                new Table { Id = 10, AreaId = 1, Name = "M10" },
                new Table { Id = 11, AreaId = 2, Name = "O1" },
                new Table { Id = 12, AreaId = 2, Name = "O2" },
                new Table { Id = 13, AreaId = 2, Name = "O3" },
                new Table { Id = 14, AreaId = 2, Name = "O4" },
                new Table { Id = 15, AreaId = 2, Name = "O5" },
                new Table { Id = 16, AreaId = 2, Name = "O6" },
                new Table { Id = 17, AreaId = 2, Name = "O7" },
                new Table { Id = 18, AreaId = 2, Name = "O8" },
                new Table { Id = 19, AreaId = 2, Name = "O9" },
                new Table { Id = 20, AreaId = 2, Name = "O10" },
                new Table { Id = 21, AreaId = 3, Name = "B1" },
                new Table { Id = 22, AreaId = 3, Name = "B2" },
                new Table { Id = 23, AreaId = 3, Name = "B3" },
                new Table { Id = 24, AreaId = 3, Name = "B4" },
                new Table { Id = 25, AreaId = 3, Name = "B5" },
                new Table { Id = 26, AreaId = 3, Name = "B6" },
                new Table { Id = 27, AreaId = 3, Name = "B7" },
                new Table { Id = 28, AreaId = 3, Name = "B8" },
                new Table { Id = 29, AreaId = 3, Name = "B9" },
                new Table { Id = 30, AreaId = 3, Name = "B10" }
                );

            mb.Entity<ReservationOrigin>()
                .HasData(
                    new ReservationOrigin { Id = 1, Name = "Phone" },
                    new ReservationOrigin { Id = 2, Name = "Email" },
                    new ReservationOrigin { Id = 3, Name = "Online" },
                    new ReservationOrigin { Id = 4, Name = "In Person" }
                );

            mb.Entity<ReservationStatus>()
                .HasData(
                    new ReservationStatus { Id = 1, Name = "Pending" },
                    new ReservationStatus { Id = 2, Name = "Confirmed" },
                    new ReservationStatus { Id = 3, Name = "Cancelled" },
                    new ReservationStatus { Id = 4, Name = "Seated" },
                    new ReservationStatus { Id = 5, Name = "Complete" }
                );
            mb.Entity<SittingType>()
                .HasData(
                    new SittingType { Id = 1, Name = "Breakfast" },
                    new SittingType { Id = 2, Name = "Lunch" },
                    new SittingType { Id = 3, Name = "Dinner" },
                    new SittingType { Id = 4, Name = "Other" }
                );
            //mb.Entity<Sitting>()
            //    .HasData(
            //        new Sitting { Id = 1, Name= "Middle Eastern Breakfast", StartTime = new DateTime(DateTime.Now.Year, 01, 01, 09, 00,00), EndTime = new DateTime(DateTime.Now.Year, 01, 01, 12, 00, 00), Capacity = 30, RestaurantId = 1, SittingTypeId = 1, IsClosed=false },
            //        new Sitting { Id = 2, Name = "Middle Eastern Lunch", StartTime = new DateTime(DateTime.Now.Year, 01, 01, 13, 00, 00), EndTime = new DateTime(DateTime.Now.Year, 01, 01, 16, 00, 00), Capacity = 30, RestaurantId = 1, SittingTypeId = 2, IsClosed = false },
            //        new Sitting { Id = 3, Name = "Middle Eastern Dinner", StartTime = new DateTime(DateTime.Now.Year, 01, 01, 17, 00, 00), EndTime = new DateTime(DateTime.Now.Year, 01, 01, 21, 00, 00), Capacity = 30, RestaurantId = 1, SittingTypeId = 3, IsClosed = false }

            //    );
        }
    }
}


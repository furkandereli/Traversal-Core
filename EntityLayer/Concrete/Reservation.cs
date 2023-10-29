using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation 
    {
        public int Id {  get; set; }
        public int AppUserId { get; set; }
        public AppUser? Appuser { get; set; }
        public string? personCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
        public int destinationId { get; set; }
        public Destination Destination {  get; set; }

    }
}

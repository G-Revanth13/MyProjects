using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace revanth.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }
        public string Hotel { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public string Type { get; set; }
        public Nullable<int> Guests { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
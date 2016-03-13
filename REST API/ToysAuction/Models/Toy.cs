using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToysAuction.Models
{
    public class Toy
    {
        public string Name { get; set; }
        public int NumberLegs { get; set;}
        public string Color { get; set; }
        public int ColorId { get; set; }
        public string Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
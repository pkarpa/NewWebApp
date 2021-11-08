using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeWebApp.Models.Data
{
    public class Rate
    {
        public int RateId { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
        public decimal Value { get; set; }
    }
}

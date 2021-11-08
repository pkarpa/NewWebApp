using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeWebApp.Models.Data
{
    public class News
    {
        public int NewsID { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public long? Count { get; set; } = 0;
    }
}

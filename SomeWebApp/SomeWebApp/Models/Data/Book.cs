using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeWebApp.Models.Data
{
    public class Book
    {
        public int BookID { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Format { get; set; }
        public string PublicationDate { get; set; }
        public string PublicationType { get; set; }
        public string Binder { get; set; }
        public int Amount { get; set; }
        public string Anotation { get; set; }
        public string ISBNCode { get; set; }
        public decimal Price { get; set; }
        public decimal Rate { get; set; }
        public uint RatesAmount { get; set; }
    }
}

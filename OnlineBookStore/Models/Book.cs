using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookStore.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookStore.Models
{
    public class OrderDTO
    {
        public class Detail
        {
            public int BookID { get; set; }
            public string Book { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        public IEnumerable<Detail> Details { get; set; }
    }
}
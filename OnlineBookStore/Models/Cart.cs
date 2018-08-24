using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBookStore.Models
{
    public class Cart
    {
        [Key]
        public int RecordID { get; set; }
        public string CartID { get; set; }
        public int BookID { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public Book Book { get; set; }
    }
}
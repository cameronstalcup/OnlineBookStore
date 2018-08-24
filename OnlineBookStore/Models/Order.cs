using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBookStore.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Required]
        public string Customer { get; set; }
        
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
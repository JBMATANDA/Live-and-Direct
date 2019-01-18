using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.Models.Entities
{
    public class CartItem
    {
        [Key]
        public int CartId { get; set; }
        public string ArticleName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
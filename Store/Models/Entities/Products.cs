using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.Models.Entities
{
    public class Products
    {
        [Key]
        public int ArticleId { get; set; }
        public string ProductType { get; set; }
        public string ArticleName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }
    }
}
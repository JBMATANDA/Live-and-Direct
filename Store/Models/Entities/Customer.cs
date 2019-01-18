using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.Models.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Firstname is required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required!")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Postcode is required!")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "City is required!")]
        public string City { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public string Phonenumber { get; set; }
    }
}
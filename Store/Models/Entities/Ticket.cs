using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int Price { get; set; }
        public DateTime ExperationDate { get; set; }
        public int MaxQuantity { get; set; }
        public int Remaining { get; set; }
        [ForeignKey("Show")]
        public int EventId { get; set; }
    }
}
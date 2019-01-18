using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models.Entities
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Ticket")]
        public int TicketId { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
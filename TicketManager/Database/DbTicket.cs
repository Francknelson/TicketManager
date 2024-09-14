using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManager.Models;

namespace TicketManager.Database
{
    [Table("tickets", Schema = "public")]
    public class DbTicket : Base
    {
        [Key]
        public int id { get; set; }
        public int employee_id { get; set; }
        public int quantity { get; set; }
        public char status { get; set; } = 'A';
        public DateTime delivery_date { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketManager.Models;

namespace TicketManager.Database
{
    [Table("employees", Schema = "public")]
    public class DbEmployee : Base
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string cpf { get; set; }
        public char status { get; set; } = 'A';

    }
}

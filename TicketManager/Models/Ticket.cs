using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManager.Database;

namespace TicketManager.Models
{
    public class Ticket : Base
    {
        internal void SetTicket(DbTicket ticket)
        {
            Context db = new Context();
            db.Tickets.Add(ticket);
            db.SaveChanges();
        }

        internal DbTicket GetTicket(int id)
        {
            Context db = new Context();
            DbTicket ticket= db.Tickets.FirstOrDefault(o => o.id == id);

            return ticket;
        }

        public List<DbTicket> GetTickets()
        {
            Context db = new Context();

            List<DbTicket> Tickets = (from t in db.Tickets
                                          select new DbTicket
                                          {
                                              id = t.id,
                                              employee_id = t.employee_id,
                                              quantity = t.quantity,
                                              status = t.status,
                                              delivery_date = t.delivery_date,
                                              created_at = t.created_at,
                                              updated_at = t.updated_at
                                          }).ToList();
            return Tickets;
        }

        public int GetEmployee(int id)
        {
            Employee employee = new Employee();
            DbEmployee emp = employee.GetEmployee(id);

            return emp.id;
        }

        internal void EditTicket(DbTicket ticket)
        {
            Context db = new Context();
            DbTicket Ticket = db.Tickets.FirstOrDefault(o => o.id == ticket.id);

            Ticket.employee_id = ticket.employee_id;
            Ticket.status = ticket.status;
            Ticket.delivery_date = ticket.delivery_date;
            db.SaveChanges();

        }

        internal void DeleteTicket(int id)
        {
            Context db = new Context();
            DbTicket Ticket = db.Tickets.FirstOrDefault(e => e.id == id);
            db.Tickets.Remove(Ticket);
            db.SaveChanges();
        }
    }
}

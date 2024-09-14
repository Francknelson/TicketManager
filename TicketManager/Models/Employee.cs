using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManager.Database;

namespace TicketManager.Models
{
    public class Employee
    {
        internal void SetEmployee(DbEmployee employee)
        {
            Context db = new Context();
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        internal DbEmployee GetEmployee(int id)
        {
            Context db = new Context();
            DbEmployee employee = db.Employees.FirstOrDefault(o => o.id == id);

            return employee;
        }

        public List<DbEmployee> GetEmployees()
        {
            Context db = new Context();

            List<DbEmployee> Employess = (from e in db.Employees
                                          select new DbEmployee
                                          { 
                                            id = e.id,
                                            name = e.name,
                                            cpf = e.cpf,
                                            status = e.status,
                                            created_at = e.created_at,
                                            updated_at = e.updated_at
                                          }).ToList();
            return Employess;
        }

        internal void EditEmployee(DbEmployee employee)
        {
            Context db = new Context();
            DbEmployee Employee = db.Employees.FirstOrDefault(o => o.id == employee.id);

            Employee.name = employee.name;
            Employee.status = employee.status;
            db.SaveChanges();

        }

        internal void DeleteEmployee(int id)
        {
            Context db = new Context();
            DbEmployee Employee = db.Employees.FirstOrDefault(e => e.id == id);
            db.Employees.Remove(Employee);
            db.SaveChanges();
        }

    }
}

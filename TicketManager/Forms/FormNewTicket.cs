using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManager.Database;
using TicketManager.Models;
using NodaTime;
using NodaTime.Extensions;
using NodaTime.Text;

namespace TicketManager.Forms
{
    public partial class FormNewTicket : Form
    {
        public FormNewTicket()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            { 
                Ticket ticket = new Ticket();
                DbTicket dbTicket = new DbTicket()
                {
                    employee_id = ticket.GetEmployee(int.Parse(cbEmployees.SelectedValue.ToString())),
                    quantity = int.Parse(textQuantity.Text),
                    delivery_date = DateTime.SpecifyKind(dtpDeliveryDate.Value, DateTimeKind.Utc)
                };

                if (textID.Text == String.Empty)
                {   
                    ticket.SetTicket(dbTicket);
                    CleanFields();   
                }
                else
                {
                    dbTicket.id = int.Parse(textID.Text);
                    ticket.EditTicket(dbTicket);
                    CleanFields();

                    Close();
                }



            }
            else
            {
                MessageBox.Show("Verifique todos os campos!");
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateFields()
        {
            if (cbEmployees.Text == String.Empty || textQuantity.Text == String.Empty || dtpDeliveryDate.Text == String.Empty)
                return false;
            else
                return true;
        }
        private void CleanFields()
        {
            textID.Text = String.Empty;
            cbEmployees.Text = String.Empty;
            textQuantity.Text = String.Empty;
            dtpDeliveryDate.Text = String.Empty;
            cbStatus.Text = String.Empty;
        }

        private void LoadEmployees()
        {
            Employee employee = new Employee();

            List<DbEmployee> list = employee.GetEmployees();

            cbEmployees.DataSource = list;
            cbEmployees.ValueMember = "ID";
            cbEmployees.DisplayMember = "Name";
        }

    }
}

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
using TicketManager.Utilities;

namespace TicketManager.Forms
{
    public partial class FormTickets : Form
    {
        public FormTickets()
        {
            InitializeComponent();
            LoadData();
            ReplaceHeaders();
        }

        private DataTable LoadData()
        {
            Ticket ticket = new Ticket();
            List<DbTicket> tickets = ticket.GetTickets();

            Employee employee = new Employee();
            List<DbEmployee> employees = employee.GetEmployees();

            var ticketWithEmployeeName = tickets.Select(ticket => new
            {
                ticket.id,
                EmployeeName = employees.FirstOrDefault(e => e.id == ticket.employee_id)?.name,
                ticket.quantity,
                ticket.status,
                ticket.delivery_date,
                ticket.created_at,
                ticket.updated_at
            }).ToList();

            ListToDataTable convert = new ListToDataTable();
            DataTable dt = convert.ToDataTable(ticketWithEmployeeName);

            dtTickets.DataSource = ticketWithEmployeeName;

            return dt;
        }

        private void Filter(DataTable dt)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "EmployeeName", textSearch.Text);
            dtTickets.DataSource = dt;
        }

        private void ReplaceHeaders()
        {
            dtTickets.Columns[0].HeaderText = "ID";
            dtTickets.Columns[1].HeaderText = "Funcionario";
            dtTickets.Columns[2].HeaderText = "Quantidade";
            dtTickets.Columns[3].HeaderText = "Status";
            dtTickets.Columns[4].HeaderText = "Entregue em";
            dtTickets.Columns[5].HeaderText = "Criado em";
            dtTickets.Columns[6].HeaderText = "Atualizado em";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormNewTicket f = new FormNewTicket();
            f.label3.Visible = false;
            f.cbStatus.Visible = false;
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter(LoadData());
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtTickets_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string data = (string)dtTickets.CurrentRow.Cells[0].Value;
            int id = int.Parse(dtTickets.CurrentRow.Cells[0].Value.ToString());
            Ticket tck = new Ticket();

            DbTicket ticket = tck.GetTicket(id);

            FormNewTicket f = new FormNewTicket();
            f.textID.Text = ticket.id.ToString();
            f.cbEmployees.Text = ticket.employee_id.ToString();
            f.textQuantity.Text = ticket.quantity.ToString();
            f.dtpDeliveryDate.Value = ticket.delivery_date;
            f.cbStatus.Text = ticket.status.ToString();
            f.Show();
        }
    }
}

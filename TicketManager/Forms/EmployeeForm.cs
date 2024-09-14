using Npgsql;
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
    public partial class EmployeeForm : Form
    {
        DataTable dt = new DataTable();

        public EmployeeForm()
        {
            InitializeComponent();
            LoadData();
            ReplaceHeaders();
        }

        private DataTable LoadData()
        {
            Employee employee = new Employee();

            List<DbEmployee> list = employee.GetEmployees();

            ListToDataTable convert = new ListToDataTable();
            DataTable dt = convert.ToDataTable(list);

            dtEmployees.DataSource = dt;

            return dt;
        }

        private void Filter(DataTable dt)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "name", textSearch.Text);
            dtEmployees.DataSource = dt;
        }

        private void ReplaceHeaders()
        {
            dtEmployees.Columns[0].HeaderText = "ID";
            dtEmployees.Columns[1].HeaderText = "Nome";
            dtEmployees.Columns[2].HeaderText = "CPF";
            dtEmployees.Columns[3].HeaderText = "Status";
            dtEmployees.Columns[4].HeaderText = "Criado em";
            dtEmployees.Columns[5].HeaderText = "Atualizado em";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormNewEmployee f = new FormNewEmployee();
            f.label3.Visible = false;
            f.cbStatus.Visible = false;
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter(LoadData());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = (string)dtEmployees.CurrentRow.Cells[0].Value;
            int id = Int32.Parse(data);
            Employee emp = new Employee();

            DbEmployee employee = emp.GetEmployee(id);

            FormNewEmployee f = new FormNewEmployee();
            f.textID.Text = employee.id.ToString();
            f.textName.Text = employee.name;
            f.textCPF.Text = employee.cpf;
            f.cbStatus.Text = employee.status.ToString();
            f.Show();
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTickets f = new FormTickets();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda nao implementado.");
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketManager.Database;
using TicketManager.Models;
using TicketManager.Utilities;

namespace TicketManager.Forms
{
    public partial class FormNewEmployee : TicketManager.Forms.FormNewBase
    {
        public FormNewEmployee()
        {
            InitializeComponent();
            textName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Employee emp = new Employee();
                DbEmployee dbEmployee = new DbEmployee()
                {
                    name = textName.Text,
                    cpf = textCPF.Text
                };

                if (textID.Text == String.Empty)
                {
                    if (ValidateCPF(textCPF.Text))
                    {
                        emp.SetEmployee(dbEmployee);
                        CleanFields();
                    }
                    else
                    {
                        MessageBox.Show("CPF ja cadastrado!");
                    }
                }
                else
                {
                    dbEmployee.id = int.Parse(textID.Text);
                    emp.EditEmployee(dbEmployee);
                    CleanFields();

                    Close();
                }
                

                
            }
            else
            {
                MessageBox.Show("Verifique todos os campos!");
            }

        }

        private bool ValidateFields()
        {
            if (textName.Text == String.Empty || !textCPF.MaskFull )
                return false;
            else
                return true;
        }

        private bool ValidateCPF(string cpf)
        {
            Employee employee = new Employee();
            List<DbEmployee> employees = employee.GetEmployees();

            if(employees.Any(employee => employee.cpf == cpf))
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }


        private void CleanFields()
        {
            textID.Text = String.Empty;
            textName.Text = String.Empty;
            textCPF.Text = String.Empty;
            cbStatus.Text = String.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanFields();
        }
    }
}

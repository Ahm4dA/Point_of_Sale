using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class addEmployeePage : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");
        public addEmployeePage()
        {
            InitializeComponent();
        }

        private void passInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (employee_radio_btn.Checked)
            {
                employee_radio_btn.Checked = false;
                admin_radio_btn.Checked = true;
            }
        }

        private void employee_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (admin_radio_btn.Checked)
            {
                admin_radio_btn.Checked = false;
                employee_radio_btn.Checked = true;
            }
        }

        private bool ifExists(string userName)
        {
            OleDbCommand cmd = new OleDbCommand("select * from Table1", connection);

            connection.Open();

            OleDbDataReader rd = cmd.ExecuteReader();

            while(rd.Read())
            {
                if(rd.GetString(1) == userName)
                {
                    return true;
                }
            }

            connection.Close();

            return false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if((!employee_radio_btn.Checked && !admin_radio_btn.Checked))
            {
                MessageBox.Show("Please select a user Type");
                return;
            }
            else if(unInput.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Username");
                return;
            }
            else if(passInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter a correct password");
                return;
            }
            else if (ifExists(unInput.Text))
            {
                MessageBox.Show("Username ALREADY in use");
                return;
            }
            else
            {
                try
                {
                    int num = admin_radio_btn.Checked ? 1 : 2;

                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Table1 ([username],[password],[userType]) values('" + unInput.Text + "', '" + passInput.Text + "', '" + num + "')";

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error! please retry");
                    return;
                }

                MessageBox.Show("Employee Successfully Added");

                this.Close();
            }
        }
    }
}

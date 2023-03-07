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
    public partial class changeEmployeePass : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");
        public changeEmployeePass()
        {
            InitializeComponent();
        }

        private bool ifUserNameExists()
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from Table1";

            connection.Open();
            OleDbDataReader readData = command.ExecuteReader();

            while(readData.Read())
            {

                if(readData.GetString(1) == unInput.Text)
                {
                    connection.Close();
                    return true;
                }
            }

            connection.Close();
            return false;
        }
        private bool checkIfInfoGiven()
        {
            if (unInput.Text == string.Empty)
            {
                MessageBox.Show("Enter User Name");
                return false;
            }
            else if (passInput.Text == string.Empty)
            {
                MessageBox.Show("Enter Password");
                return false;
            }

            return true;
        }
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (!checkIfInfoGiven())
                return;

            if (!ifUserNameExists())
            {
                MessageBox.Show("User not Found");
                return;
            }

            string query = "update Table1 set [password] = '" + passInput.Text + "' where username = '" + unInput.Text + "'";

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");
            OleDbCommand command = new OleDbCommand(query, connection);


            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Password changed Successfully");
        }

        private void unInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

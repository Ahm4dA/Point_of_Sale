using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginPage : Form
    {

        // checks whether the input was given or not
        private bool checkIfInputGiven()
        {

            if(unInput.Text == string.Empty || passLabel.Text == string.Empty)
                return false;

            return true;
        }

        private bool verifyInput(string username, string password)
        {

            if (username.Length == unInput.Text.Length && password.Length == passInput.Text.Length)
            {

                int length = username.Length - 1;

                while (length >= 0)
                {

                    if (username[length] != unInput.Text[length])
                        return false;

                    length--;
                }

                length = password.Length - 1;

                while (length >= 0)
                {

                    if (password[length] != passInput.Text[length])
                        return false;

                    length--;
                }
            }
            else
                return false;

            return true;

        }
        public loginPage()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!checkIfInputGiven())
            {
                MessageBox.Show("Enter correct Info");
            }
            else
            {
                
                string query = "select * from Table1";

                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

                OleDbCommand command = new OleDbCommand(query, connection);

                bool verifyLogin = false;

                connection.Open();

                OleDbDataReader rd = command.ExecuteReader();

                string readUserName = string.Empty;
                string readPassWord = string.Empty;
                int num = 0;

                while (rd.Read() && !verifyLogin)
                {

                    readUserName = rd.GetString(1);
                    readPassWord = rd.GetString(2);
                    num = rd.GetInt32(3);

                    if(verifyInput(readUserName, readPassWord))
                    {
                        verifyLogin = true;
                    }

                    readUserName = string.Empty;
                    readPassWord = string.Empty;
                }

                connection.Close();

                if(!verifyLogin)
                {
                    MessageBox.Show("INVALID PASSWORD");
                    unInput.Text = string.Empty;
                    passInput.Text = string.Empty;
                }
                else
                {
                    mainPage addEmployeeForm = new mainPage(num, unInput.Text.ToString());
                    this.Hide();
                    addEmployeeForm.ShowDialog();

                    this.Close();
                }

            }
        }

    }
}

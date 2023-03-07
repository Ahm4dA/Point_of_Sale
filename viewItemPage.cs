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
    public partial class viewItemPage : Form
    {
        public viewItemPage()
        {
            InitializeComponent();

            label2.Text = label4.Text = label5.Text = String.Empty;
        }

        private void viewItemPage_Load(object sender, EventArgs e)
        {

        }

        private int stringToInt(string PD)
        {
            return Convert.ToInt32(PD);
        }

        private string IntToString(int data)
        {
            return Convert.ToString(data);
        }
        private void checkProductID_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(productID_Input.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("INVALID PRODUCT ID");
                return;
            }

            if(productID_Input.Text == string.Empty)
            {
                MessageBox.Show("Please Enter product ID");
            }
            else
            {
                bool flag = false;

                int productIDInput = stringToInt(productID_Input.Text);

                string query = "select * from ProductInfo";

                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

                OleDbCommand command = new OleDbCommand(query, connection);

                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read() && !flag)
                {

                    if (reader.GetInt32(1) == productIDInput)
                    {
                        label5.Text = reader.GetString(2);
                        label4.Text = IntToString(reader.GetInt32(3));
                        label2.Text = IntToString(reader.GetInt32(4));

                        flag = true;
                    }
                }

                if (!flag)
                {
                    MessageBox.Show("Invalid Product ID");
                    label5.Text = String.Empty;
                    label4.Text = String.Empty;
                    label2.Text = String.Empty;
                }

                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

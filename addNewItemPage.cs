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
    public partial class addNewItemPage : Form
    {
        private bool verifyInfo()
        {
            // verify inputs
            if (productID_input.Text == String.Empty)
            {
                MessageBox.Show("Enter a product ID");
                return false;
            }
            else if (name_input.Text == string.Empty)
            {
                MessageBox.Show("Enter Product Name");
                return false;
            }
            else if (price_input.Text == string.Empty)
            {
                MessageBox.Show("Enter Product Price");
                return false;
            }

            int len = productID_input.Text.Length - 1;

            while (len >= 0)
            {
                if (char.IsLetter(productID_input.Text[len]))
                {
                    MessageBox.Show("Enter VALID product ID");
                    return false;
                }

                len--;
            }

            len = price_input.Text.Length - 1;

            while (len >= 0)
            {
                if (char.IsLetter(price_input.Text[len]))
                {
                    MessageBox.Show("Enter VALID Price");
                    return false;
                }

                len--;
            }

            len = quantity_input.Text.Length - 1;

            while (len >= 0)
            {
                if (char.IsLetter(quantity_input.Text[len]))
                {
                    MessageBox.Show("Enter VALID Quantity");
                    return false;
                }

                len--;
            }

            return true;
        }

        private bool checkID_unique()
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from ProductInfo";
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetInt32(1) == Convert.ToInt32(productID_input.Text))
                {
                    connection.Close();
                    return false;
                }
            }

            connection.Close();
            return true;
        }

        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");
        public addNewItemPage()
        {
            InitializeComponent();
        }

        private void productID_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            // validate int only input

            int temp = 0;
            bool checkStop = false;

            try
            {
                temp = Convert.ToInt32(productID_input.Text);
            }
            catch(Exception ex)
            {
                productID_input.Text = string.Empty;
                checkStop = true;
                MessageBox.Show("INVALID PRODUCT ID");
            }

            try
            {
                temp = Convert.ToInt32(price_input.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID PRICE");
                price_input.Text = string.Empty;
                checkStop = true;
            }

            try
            {
                temp = Convert.ToInt32(quantity_input.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID QUANTITY");
                quantity_input.Text = string.Empty;
                checkStop = true;
            }

            if (checkStop)
            {
                return;
            }

            // verify data

            if (verifyInfo())
            {
                if (checkID_unique())
                {
                    int quantity = 0;

                    OleDbCommand command = new OleDbCommand();

                    command.Connection = connection;

                    if (quantity_input.Text != string.Empty)
                        quantity = Convert.ToInt32(quantity_input.Text);

                    string query = "INSERT INTO ProductInfo ([productID],[productName],[productPrice],[productQuantity]) values('" + Convert.ToInt32(productID_input.Text) + "', '" + name_input.Text + "', '" + Convert.ToInt32(price_input.Text) + "', '" + quantity + "')";

                    command.CommandText = query;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Item Added Successfully");

                    productID_input.Text = string.Empty;
                    name_input.Text = String.Empty;
                    price_input.Text = String.Empty;
                    quantity_input.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Product ID already in USE");
                    productID_input.Text = string.Empty;
                    return;
                }
                
            }
        }
    }
}

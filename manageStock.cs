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
    public partial class manageStock : Form
    {
        private bool add_stock_flag = false;
        private bool remove_stock_flag = false;
        private bool edit_stock_flag = false;
        

        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");
        public manageStock()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            label2.Text = label3.Text = label4.Text = String.Empty;
            name_label.Text = price_label.Text = quantity_label.Text = String.Empty;


            // before buttons are pressed ,, this will make them disappear

            labelToChange.Text = String.Empty;

            // original size = 243, 34

            this.inputData.Size = new System.Drawing.Size(0, 0);

            // original size = 170, 52

            this.confirm_btn.Size = new System.Drawing.Size(0, 0);
        }

        private void manageStock_Load(object sender, EventArgs e)
        {

        }

        private void whenCompleted()
        {
            label2.Text = label3.Text = label4.Text = String.Empty;
            name_label.Text = price_label.Text = quantity_label.Text = String.Empty;

            // this will make the buttons disappear when anything is changed

            // before buttons are pressed ,, this will make them disappear

            labelToChange.Text = String.Empty;

            // original size = 243, 34

            this.inputData.Size = new System.Drawing.Size(0, 0);

            // original size = 170, 52

            this.confirm_btn.Size = new System.Drawing.Size(0, 0);

            //changeing value of data which was entered to null;

            this.inputData.Text = String.Empty;
        }
        private bool searchProduct()
        {
            int price_product = 0;
            string name_product = string.Empty;
            int quantity_product = 0;

            bool ifID_found = false;
            int productID_in_Int = Convert.ToInt32(productID_Input.Text);

            string query = "select * from ProductInfo";

            connection.Open();

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader readData = command.ExecuteReader();

            while (readData.Read() && !ifID_found)
            {

                int PD_data = readData.GetInt32(1);

                if (PD_data == productID_in_Int)
                {

                    ifID_found = true;
                    name_product = readData.GetString(2);
                    price_product = readData.GetInt32(3);
                    quantity_product = readData.GetInt32(4);
                }
            }

            connection.Close();

            if (!ifID_found)
            {
                MessageBox.Show("Invalid Product ID");
                productID_Input.Text = String.Empty;
                return false;
            }
            else
            {
                label2.Text = "Name";
                label3.Text = "Quantity";
                label4.Text = "Price";

                name_label.Text = name_product;
                price_label.Text = Convert.ToString(price_product);
                quantity_label.Text = Convert.ToString(quantity_product);

                return true;
            }
        }

        private void add_stock_btn_Click(object sender, EventArgs e)
        {

            if (productID_Input.Text == String.Empty)
            {
                MessageBox.Show("Please enter a product ID");
                return;
            }
            else
            {
                add_stock_flag = true;
                remove_stock_flag = edit_stock_flag = false;

                if (!searchProduct())
                {
                    return;
                }

            }
            //allows to make things appear
            labelToChange.Text = "Enter Quantity";
            inputData.Size = new System.Drawing.Size(243, 34);
            confirm_btn.Size = new System.Drawing.Size(170, 52);
            //this.inputData.Location = new System.Drawing.Point(60, 542);
            //this.confirm_btn.Location = new System.Drawing.Point(344, 530);

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(productID_Input.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID PRODUCT ID");
                return;
            }

            if (productID_Input.Text == String.Empty)
            {
                MessageBox.Show("Please enter product ID");
            }
            else
            {
                searchProduct();
            }
        }

        private void remove_stock_btn_Click(object sender, EventArgs e)
        {
            if (productID_Input.Text == String.Empty)
            {
                MessageBox.Show("Please enter a product ID");
                return;
            }
            else
            {
                remove_stock_flag = true;
                add_stock_flag = edit_stock_flag = false;

                if (!searchProduct())
                {
                    return;
                }

            }

            //allows to make things appear
            labelToChange.Text = "Enter Quantity";
            inputData.Size = new System.Drawing.Size(243, 34);
            confirm_btn.Size = new System.Drawing.Size(170, 52);
            //this.inputData.Location = new System.Drawing.Point(60, 542);
            //this.confirm_btn.Location = new System.Drawing.Point(344, 530);

        }

        private void edit_price_btn_Click(object sender, EventArgs e)
        {
            if (productID_Input.Text == String.Empty)
            {
                MessageBox.Show("Please enter a product ID");
                return;
            }
            else
            {
                edit_stock_flag = true;
                add_stock_flag = add_stock_flag = false;

                if (!searchProduct())
                {
                    return;
                }

            }

            //allows to make things appear
            labelToChange.Text = "Enter New Price";
            inputData.Size = new System.Drawing.Size(243, 34);
            confirm_btn.Size = new System.Drawing.Size(170, 52);


        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(inputData.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID INPUT");
                return;
            }

            if (inputData.Text == String.Empty)
            {
                if (labelToChange.Text == "Enter New Price")
                {
                    MessageBox.Show("Please enter correct price");
                }
                else
                {
                    MessageBox.Show("Enter corrent quantity");
                }
            }
            else
            {

                int value = Convert.ToInt32(inputData.Text);

                if (value > 0)
                {
                    string query = string.Empty;

                    //creating connection
                    OleDbCommand command = new OleDbCommand();

                    command.Connection = connection;

                    if (edit_stock_flag)
                    {
                        query = "UPDATE ProductInfo SET productPrice = " + value + " WHERE productID=" + productID_Input.Text;

                        command.CommandText = query;

                        connection.Open();

                        command.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Price updated");

                        whenCompleted();
                    }
                    else
                    {
                        int valueOld = Convert.ToInt32(quantity_label.Text);


                        int valueUpdated = 0;

                        if (add_stock_flag)
                        {
                            valueUpdated = value + valueOld;

                        }
                        else if (remove_stock_flag)
                        {
                            valueUpdated = valueOld - value;

                        }

                        if (valueUpdated >= 0)
                        {
                            query = "UPDATE ProductInfo SET productQuantity = " + valueUpdated + " WHERE productID=" + productID_Input.Text;

                            command.CommandText = query;

                            connection.Open();

                            command.ExecuteNonQuery();

                            connection.Close();

                            MessageBox.Show("Stock Quantity Updated");

                            whenCompleted();
                        }
                        else
                        {
                            MessageBox.Show("Stock quantity INVALID");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter correct value");
                }


            }
        }

    }
}

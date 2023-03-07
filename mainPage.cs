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
    public partial class mainPage : Form
    {
        private string employeeName = string.Empty;
        private int productID_yet = 0;
        private int loginType = -1;
        public mainPage()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

        }

        public mainPage(int n, string userName)
        {
            InitializeComponent();

            // makes some of the columns of gridview or bill uneditable

            this.dataGridView1.Columns[4].ReadOnly = true;
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
            this.dataGridView1.Columns[6].ReadOnly = true;

            //check if to allow
            this.dataGridView1.Columns[1].ReadOnly = true;

            //store login type
            loginType = n;

            if (n == 2)
            {
                this.add_employee_btn.Size = new System.Drawing.Size(0, 0);
                this.change_pass_btn.Size = new System.Drawing.Size(0, 0);
                this.label1.Text = String.Empty;
                this.label3.Text = String.Empty;
            }

            total_label.Text = "0";

            employeeName = userName;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    {
                        if (loginType != 2)
                        {
                            addEmployeePage addEmployeePageH = new addEmployeePage();

                            addEmployeePageH.Show();
                        }
                    }
                    break;
                case Keys.F2:
                    {
                        if (loginType != 2)
                        {
                            changeEmployeePass CP_page_new = new changeEmployeePass();

                            CP_page_new.Show();
                        }
                    }
                    break;
                case Keys.F3:
                    {
                        manageStock manageStockPage = new manageStock();

                        manageStockPage.Show();
                    }
                    break;
                case Keys.F4:
                    {
                        viewItemPage viewItemPageH = new viewItemPage();

                        viewItemPageH.Show();
                    }
                    break;
                case Keys.F6:
                    {
                        addNewItemPage addNewItemPageH = new addNewItemPage();

                        addNewItemPageH.Show();
                    }
                    break;
                case Keys.F7:
                    {
                        promptGetTID ptr = new promptGetTID();

                        ptr.ShowDialog();
                    }
                    break;
                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void totalling()
        {
            int total = 0;

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                {
                    total += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
            }

            total_label.Text = total.ToString();
        }
        private bool ID_true()
        {
            string query = "select * from ProductInfo";

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

            OleDbCommand command = new OleDbCommand(query, connection);

            connection.Open();

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                  
                if (reader.GetInt32(1) == Convert.ToInt32(ID_Input.Text))
                {
                    connection.Close();
                    return true;
                }
            }

            connection.Close();
            return false;
        }

        private int ID_InGrid()
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == ID_Input.Text)
                {
                    if(dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        return i + 1;
                    }
                }
            }

            return 0;
        }

        private void EnterDataInGrid()
        {
            // checks if entered data is a number of if there is another character in it

            try
            {
                int ID_Check = Convert.ToInt32(ID_Input.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("INVALID ID INPUT");

                ID_Input.Text = String.Empty;

                return;
            }

            // checks if the input string is empty or not

            if(ID_Input.Text == string.Empty)
            {
                MessageBox.Show("Enter Product ID");
                return;
            }
            else
            {
                //verifies if the string i.e. the product ID exists in Database

                if (!ID_true())
                {
                    MessageBox.Show("INVALID Product ID");
                    return;
                }
                else
                {
                    int check = ID_InGrid();
                    bool flag = (check == 0) ? false : true;

                    if (flag)
                    {
                        dataGridView1.Rows[check - 1].Cells[3].Value = (Convert.ToInt16(dataGridView1.Rows[check - 1].Cells[3].Value.ToString()) + 1).ToString();
                        dataGridView1.Rows[check - 1].Cells[6].Value = (Convert.ToInt16(dataGridView1.Rows[check - 1].Cells[4].Value.ToString()) + Convert.ToInt16(dataGridView1.Rows[check - 1].Cells[6].Value.ToString())).ToString();
                        totalling();
                    }
                    else
                    {
                        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

                        OleDbCommand command = new OleDbCommand("select * from ProductInfo", connection);

                        connection.Open();

                        OleDbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            //if found, enters data in gridview

                            if (reader.GetInt32(1) == Convert.ToInt32(ID_Input.Text))
                            {
                                dataGridView1.Rows.Add();

                                dataGridView1.Rows[productID_yet].Cells[0].Value = productID_yet + 1;
                                dataGridView1.Rows[productID_yet].Cells[1].Value = ID_Input.Text;
                                dataGridView1.Rows[productID_yet].Cells[2].Value = reader.GetString(2);
                                dataGridView1.Rows[productID_yet].Cells[3].Value = Convert.ToString(1);
                                dataGridView1.Rows[productID_yet].Cells[4].Value = Convert.ToString(reader.GetInt32(3));
                                dataGridView1.Rows[productID_yet].Cells[5].Value = Convert.ToString(0);
                                dataGridView1.Rows[productID_yet].Cells[6].Value = Convert.ToString(reader.GetInt32(3));

                                productID_yet++;
                                connection.Close();
                                totalling();
                                return;
                            }
                        }

                        connection.Close();
                    }
                    return;
                }
            }
        }

        //private bool already_exists()
        //{
            
        //}

        void ID_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                EnterDataInGrid();
                ID_Input.Text = String.Empty;
            }
        }
        private void view_stock_btn_Click(object sender, EventArgs e)
        {
            // opens new page of view item details

            viewItemPage viewItemPageH = new viewItemPage();

            viewItemPageH.Show();
        }

        private void add_employee_btn_Click(object sender, EventArgs e)
        {
            // opens new window of add new employee

            addEmployeePage addEmployeePageH = new addEmployeePage();

            addEmployeePageH.Show();
        }

        private void handle_stock_btn_Click(object sender, EventArgs e)
        {
            manageStock manageStockPage = new manageStock();

            manageStockPage.Show();
        }

        private void add_new_product_btn_Click(object sender, EventArgs e)
        {
            addNewItemPage addNewItemPageH = new addNewItemPage();

            addNewItemPageH.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginPage loginPageH = new loginPage();
            this.Hide();
            loginPageH.ShowDialog();
            this.Close();
        }

        private void change_pass_btn_Click(object sender, EventArgs e)
        {
            changeEmployeePass CP_page_new = new changeEmployeePass();

            CP_page_new.Show();

        }

        private void dataGridView1_KeyDown(object sender, DataGridViewCellEventArgs e)
        {
            // if quantity changed
            if (e.ColumnIndex == 3)
            {
                try
                {
                    if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) == 0)
                    {
                        BeginInvoke(new MethodInvoker(delegate
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }));

                        productID_yet--;

                        for (int i = 0, count = 0; i < dataGridView1.Rows.Count; i++)
                        {

                            if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                            {
                                dataGridView1.Rows[i].Cells[0].Value = (count + 1).ToString();
                                count++;
                            }
                        }

                        totalling();
                    }
                    else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) < 0)
                    {
                        // check if we go back to original value
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = Convert.ToString(1);

                        // check what to do eh .... krna kia han.... check kroo database se.... heheh nvm price ke column se chuk lo

                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = dataGridView1.Rows[e.RowIndex].Cells[4].Value;

                        // if discount was there

                        if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() != "0")
                        {
                            int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                            int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                            int discount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

                            int total = (quantity * price) - discount;

                            dataGridView1.Rows[e.RowIndex].Cells[6].Value = total.ToString();
                        }

                        totalling();
                    }
                    else
                    {
                        // just changes the price cause you know quantity changed hehehehehe

                        int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                        int discount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

                        int total = (quantity * price) - discount;

                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = total.ToString();
                    }

                    totalling();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("INVALID QUANTITY VALUE");

                    // check if we go back to original value
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = Convert.ToString(1);

                    // check what to do eh .... krna kia han.... check kroo database se.... heheh nvm price ke column se chuk lo

                    dataGridView1.Rows[e.RowIndex].Cells[6].Value = dataGridView1.Rows[e.RowIndex].Cells[4].Value;

                    // if discount was there

                    if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() != "0")
                    {
                        int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                        int discount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

                        int total = (quantity * price) - discount;

                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = total.ToString();
                    }

                    totalling();
                }
            }
            else if(e.ColumnIndex == 5)
            {
                //changing discount value

                try
                {

                    int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    int discount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

                    if (discount < 0)
                    {
                        discount = 0;
                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = "0";
                    }

                    int total = (quantity * price) - discount;

                    dataGridView1.Rows[e.RowIndex].Cells[6].Value = total.ToString();

                    totalling();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("INVALID DISCOUNT VALUE");

                    int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = "0";

                    int total = (quantity * price);

                    dataGridView1.Rows[e.RowIndex].Cells[6].Value = total.ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            if(productID_yet == 0)
            {
                MessageBox.Show("No Item in Bill");
                return;
            }

            totalling();

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

            OleDbCommand command = connection.CreateCommand();

            command.CommandText = "select * from ProductInfo";

            bool flagStop = true;
            bool flag = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                {
                    connection.Open();
                    OleDbDataReader rd = command.ExecuteReader();
                    flagStop = true;

                    while (rd.Read() && flagStop)
                    {
                        if (rd.GetInt32(1).ToString() == dataGridView1.Rows[i].Cells[1].Value.ToString())
                        {
                            if (rd.GetInt32(4) - Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString()) < 0)
                            {
                                MessageBox.Show(dataGridView1.Rows[i].Cells[2].Value.ToString() + " is out of stock");
                                dataGridView1.Rows[i].Cells[3].Value = "1";

                                // just changes the price cause you know quantity changed hehehehehe

                                int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                                int price = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                                int discount = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());

                                int total = (quantity * price) - discount;

                                dataGridView1.Rows[i].Cells[6].Value = total.ToString();

                                totalling();
                                flag = true;
                            }

                            flagStop = false;
                        }
                    }

                    connection.Close();
                }
            }

            if (flag)
                return;

            connection.Close();

            payPage payment = new payPage(dataGridView1, Convert.ToInt32(total_label.Text), employeeName);

            payment.ShowDialog();
        
        }
        
        private void clear_bill_btn_Click(object sender, EventArgs e)
        {
            // deleting the last one

            dataGridView1.DataSource = null;

            dataGridView1.Rows.Clear();

            productID_yet = 0;

            total_label.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //printBill ptr = new printBill();

            //viewTransaction ptr = new viewTransaction();

            promptGetTID ptr = new promptGetTID();

            ptr.ShowDialog();
        }
    }
}

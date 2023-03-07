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
    public partial class payPage : Form
    {
        public string employeeName = string.Empty;
        public int totall;
        private int pressCount = 0;
        public DataGridView billData;
        public int changePublic = 0;
        public payPage()
        {
            InitializeComponent();
        }

        public payPage(DataGridView bill,int total, string employeeNameLogin)
        {
            InitializeComponent();

            this.employeeName = employeeNameLogin;

            this.billData = bill;
            totall = total;

            this.price_total_label.Text = total.ToString();
            this.change_label.Text = String.Empty;
        }
        private void amountInput_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                if(pressCount == 0)
                {
                    int total = Convert.ToInt32(this.price_total_label.Text);
                    int amount = 0;

                    try
                    {
                        amount = Convert.ToInt32(this.amountInput.Text);
                        
                    }
                    catch(Exception ex)
                    {
                        pressCount = 0;
                        this.amountInput.Text = String.Empty;
                    }

                    int change = amount - total;
                    changePublic = change;

                    // if change is negative give message box
                    if(change < 0)
                    {
                        MessageBox.Show("Enter correct amount");
                        return;
                    }

                    this.change_label.Text = change.ToString();

                    pressCount++;
                }
                else if(pressCount == 1)
                {

                    // first add transactionData Shit

                    String transactionDate = DateTime.Now.ToString("ddMMyyyy");

                    DateTime now = DateTime.Now;
                    DateTime end = new DateTime(1999, 01, 01, 00, 00, 00);

                    string transactionID = (now - end).TotalSeconds.ToString();

                    int length = transactionID.Length;

                    string temp = string.Empty;

                    for(int i = 0; i < length && transactionID[i] != '.'; i++)
                        temp = temp + transactionID[i];


                    OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    connection.Close();

                    // now store all the items

                    connection.Open();

                    for (int i = 0; i < billData.Rows.Count; i++)
                    {
                        if (billData.Rows[i].Cells[3].Value.ToString() != "0")
                        {

                            command.CommandText = "INSERT INTO Transactions ([ID],[productName],[quantity],[productPrice],[discount],[totalPrice],[cashier],[transactionDate],[grandTotal],[paid],[change],[transactionID]) values('" + billData.Rows[i].Cells[0].Value.ToString() + "', '" + billData.Rows[i].Cells[2].Value.ToString() + "', '" + billData.Rows[i].Cells[3].Value.ToString() + "', '" + billData.Rows[i].Cells[4].Value.ToString() + "', '" + billData.Rows[i].Cells[5].Value.ToString() + "', '" + billData.Rows[i].Cells[6].Value.ToString() + "', '" + employeeName + "', '" + transactionDate + "', '" + totall + "', '" + amountInput.Text + "', '" + change_label.Text + "', '" + temp + "')";
                            command.ExecuteNonQuery();

                            // changing quantity in table

                            // first get original quantity

                            OleDbConnection connection2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");
                            OleDbCommand command2 = new OleDbCommand();
                            command2.Connection = connection2;
                            command2.CommandText = "select * from productInfo";
                            connection2.Open();
                            OleDbDataReader rd = command2.ExecuteReader();
                            bool flag = true;
                            int quantity = 0;

                            while(rd.Read() && flag)
                            {
                                quantity = rd.GetInt32(1);

                                if (quantity == Convert.ToInt32(billData.Rows[i].Cells[1].Value.ToString()))
                                {
                                    quantity = rd.GetInt32(4);
                                    flag = false;
                                }
                            }

                            connection2.Close();

                            command2.CommandText = "UPDATE ProductInfo SET productQuantity = " + (quantity - Convert.ToInt32(billData.Rows[i].Cells[3].Value.ToString())) + " WHERE productID=" + Convert.ToInt32(billData.Rows[i].Cells[1].Value.ToString());
                            connection2.Open();
                            command2.ExecuteNonQuery();
                            connection2.Close();

                            command2.Connection = connection2;
                            command2.CommandText = "select * from dailyTransactions";
                            connection2.Open();
                            rd = command2.ExecuteReader();
                            int sale = -1;
                            flag = true;

                            while (rd.Read() && flag)
                            {
                                if(rd.GetString(1) == transactionDate)
                                {
                                    sale = Convert.ToInt32(rd.GetString(2));
                                    flag = false;
                                }
                            }

                            connection2.Close();

                            if (flag)
                            {
                                sale = totall;

                                command2.Connection = connection2;
                                command2.CommandText = "INSERT INTO dailyTransactions ([transactionDate],[totalSale]) values('" + transactionDate + "', '" + sale.ToString() + "')";
                                connection2.Open();
                                command2.ExecuteNonQuery();
                                connection2.Close();
                            }
                            else
                            {
                                sale = sale + totall;
                                OleDbCommand cmdd = new OleDbCommand();
                                cmdd.Connection = connection2;
                                cmdd.CommandText = "UPDATE dailyTransactions SET totalSale = '" + sale.ToString() + "' WHERE transactionDate='" + transactionDate.ToString() + "'";
                                //command2.CommandText = "UPDATE dailyTransactions SET totalSale = " + sale.ToString();
                                connection2.Open();
                                cmdd.ExecuteNonQuery();
                                connection2.Close();
                            }
                        }
                    }

                    connection.Close();

                    //MessageBox.Show("Bill Paid");

                    printBill ptr = new printBill(temp);

                    ptr.ShowDialog();

                    this.totall = -1;

                    this.Close();
                }
            }
            else
            {
                if (pressCount == 0)
                    return;

                pressCount--;
            }
        }

        private void payPage_Load(object sender, EventArgs e)
        {

        }

        private void change_label_Click(object sender, EventArgs e)
        {

        }
    }
}

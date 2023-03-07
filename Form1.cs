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
    public partial class viewTransaction : Form
    {
        private bool byID = false;
        private bool byDate = false;
        private string dateLast = string.Empty;

        public viewTransaction()
        {
            InitializeComponent();

            dateLast = monthCalendar1.SelectionRange.Start.ToString("ddMMyyyy");
            monthCalendar1.Size = new Size(0, 0);
            // correct = 227, 162
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //if (e.Start.ToString("ddMMyyyy") != dateLast)
            //{
            //    var startDate = monthCalendar1.SelectionRange.Start.ToString("ddMMyyyy");

            //    if (startDate != dateLast)
            //        MessageBox.Show(startDate);

            //    dateLast = startDate;
            //}
        }

        void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bool flag = true;
                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

                OleDbCommand command = new OleDbCommand("select * from Transactions", connection);

                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while(reader.Read() && flag)
                {
                    if(reader.GetString(12) == textBox1.Text)
                    {
                        flag = false;
                    }
                }

                connection.Close();

                if (!flag)
                {
                    printBill ptr = new printBill(textBox1.Text);

                    ptr.Show();
                }
                else
                {
                    MessageBox.Show("INVALID TRANSACTION ID");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

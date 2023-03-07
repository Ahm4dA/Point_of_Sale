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
    public partial class promptGetTID : Form
    {
        public promptGetTID()
        {
            InitializeComponent();
        }

        private void promptGetTID_Load(object sender, EventArgs e)
        {

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

                while (reader.Read() && flag)
                {
                    if (reader.GetString(12) == textBox1.Text)
                    {
                        flag = false;
                    }
                }

                connection.Close();

                if (!flag)
                {
                    printBill ptr = new printBill(textBox1.Text);

                    ptr.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("INVALID TRANSACTION ID");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class printBill : Form
    {
        private string tID = string.Empty;
        public printBill(string transactionID)
        {
            InitializeComponent();

            tID = transactionID;
        }

        private void loadBill()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\programming files\WindowsFormsApp1\loginTable.accdb");

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from Transactions where transactionID='" + tID + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable1");

            Microsoft.Reporting.WinForms.ReportDataSource datasource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet_Report", ds.Tables[0]);


            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
        private void printBill_Load(object sender, EventArgs e)
        {

            loadBill();
        }

    }
}

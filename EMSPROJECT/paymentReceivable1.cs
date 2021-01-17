using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EMSPROJECT
{
    public partial class paymentReceivable1 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\iQais\Desktop\Project SC WORK\EMSPROJECT\Db\EMSDB.accdb");
        private OleDbDataAdapter _adapter;
        private DataSet _dataset;
        public paymentReceivable1()
        {
            InitializeComponent();
        }

        private void paymentReceivable1_Load(object sender, EventArgs e)
        {
            try
            {
                _adapter = new OleDbDataAdapter("select * from [paymentReceivableQuery]", con);
                _dataset = new DataSet();
                _adapter.Fill(_dataset, "p");
                dataGridView1.DataSource = _dataset.Tables["p"];

                con.Close();

            }
            catch
            {
                MessageBox.Show("Something Went Wrong", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

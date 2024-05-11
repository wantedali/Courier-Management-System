using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace swe_LogPage
{
    public partial class Form6 : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "data source=orcl;user id=scott;password=tiger;";
            string s = "SELECT * from members";
            adapter = new OracleDataAdapter(s, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}

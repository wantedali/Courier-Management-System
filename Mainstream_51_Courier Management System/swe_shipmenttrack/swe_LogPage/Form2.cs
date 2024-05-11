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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace swe_LogPage
{
    public partial class Form2 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
             string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string EMAIL, password;
            EMAIL = textBox1.Text;
            password = textBox2.Text;

            try
            {
                string querry = "SELECT * FROM USERS WHERE EMAIL = '" + textBox1.Text + "' AND PASSWORDHASH ='" + textBox2.Text + "' ";

                OracleDataAdapter sda = new OracleDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    EMAIL = textBox1.Text;
                    password = textBox2.Text;

                    MessageBox.Show("User Logged In successfully.");

                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("UserName or password is Invalid.");
                }
            }
            catch
            {
                MessageBox.Show("ERROR!");

            }
        }
    }
}

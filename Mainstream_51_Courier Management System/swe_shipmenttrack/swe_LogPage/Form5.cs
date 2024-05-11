using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.DataAccess.Types;
namespace swe_LogPage
{
    public partial class Form5 : Form
    {
        OracleConnection conn;
        private string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public Form5()
        {
            InitializeComponent();
            comboBox1.Items.Add("Fast");
            comboBox1.Items.Add("Normal");
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            textBox5.Text = "0";
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int cost = 0;
            try
            {

                if
                    (comboBox1.SelectedItem.ToString() == "Fast")
                    cost = Convert.ToInt32(textBox5.Text) * 4;
                else cost = Convert.ToInt32(textBox5.Text) * 2;
            }
            catch
            {
            }
            label9.Text = cost.ToString() + "$";
        }
        private int GetUser(String email)
        {
            int id = -1;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT UserID FROM Users WHERE Email = :email";
            cmd.Parameters.Add("email", email);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["UserID"]);
            }
            reader.Close();
            return id;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int maxID, newID,maxTid,newTid;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "shipID";
            cmd2.CommandType = CommandType.StoredProcedure;

            cmd2.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd2.ExecuteNonQuery();

            try
            {
                maxID = Convert.ToInt32(cmd2.Parameters["id"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            {
                newID = 1;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Shipments (ShipmentID,SenderID, RecipientID, RecipientAddress, RecipientContact, Description, Dimensions, Speed, Status, invoice,START_SHIPMENT_DATE,ARRIVAL_SHIPMENT_DATE,TRACKINGID) VALUES (:p_ship,:p_senderID, :p_recipientId, :p_recipientAddress, :p_recipientContact, :p_description, :p_dimensions, :p_speed, :p_status, :p_invoice,:p_START_SHIPMENT_DATE,:p_ARRIVAL_SHIPMENT_DATE,:p_trid)";
            cmd.Parameters.Add("idd", newID);
            cmd.Parameters.Add("p_senderID", GetUser(textBox6.Text));//edit this line to get the logged in user
            cmd.Parameters.Add("p_recipientId", textBox1.Text);
            cmd.Parameters.Add("p_recipientAddress", textBox2.Text);
            cmd.Parameters.Add("p_recipientContact", textBox3.Text);
            cmd.Parameters.Add("p_description", textBox4.Text);
            cmd.Parameters.Add("p_weight", textBox5.Text);
            cmd.Parameters.Add("p_speed", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("p_status", "pending");
            int cost = 0;
            if (comboBox1.SelectedItem.ToString() == "Fast")
                cost = Convert.ToInt32(textBox5.Text) * 4;
            else cost = Convert.ToInt32(textBox5.Text) * 2;
            cmd.Parameters.Add("p_cost", cost);

            cmd.Parameters.Add("p_start", DateTime.Now);
            if (comboBox1.SelectedItem.ToString() == "Fast")
                cmd.Parameters.Add("p_ARRIVAL_SHIPMENT_DATE", DateTime.Now.AddDays(3));
            else cmd.Parameters.Add("p_ARRIVAL_SHIPMENT_DATE", DateTime.Now.AddDays(7));

            label9.Text = cost.ToString() + "$";
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "trackID";
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("od", OracleDbType.Int32, ParameterDirection.Output);
            cmd3.ExecuteNonQuery();
            try
            {
                maxTid = Convert.ToInt32(cmd3.Parameters["od"].Value.ToString());
                newTid= maxTid + 1;
            }
            catch
            {
                newTid = 1;
            }
            cmd.Parameters.Add("p_trid", newTid);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Shipment sent successfully. Tracking ID: " + newTid);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace swe_LogPage
{
    public partial class Form4 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void track_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            string shipment_id = ship_id.Text;

            int shipmentID;
            if (!int.TryParse(shipment_id, out shipmentID))
            {
                MessageBox.Show("Invalid shipment ID.");
                return;
            }

            cmd.CommandText = "SELECT Status, Start_shipment_date, Arrival_Shipment_Date FROM Shipments WHERE ShipmentID = :shipmentID";

            cmd.Parameters.Add("shipmentID", OracleDbType.Int64).Value = shipmentID;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                status.Text = dr["Status"].ToString();
                star_ship.Text = dr["Start_shipment_date"].ToString();
                arrival_ship.Text = dr["Arrival_Shipment_Date"].ToString();
            }
            else
            {
                MessageBox.Show("Shipment not found.");
            }

            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}

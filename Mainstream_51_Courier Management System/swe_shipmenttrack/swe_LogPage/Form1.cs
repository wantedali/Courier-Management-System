using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace swe_LogPage
{
    public partial class Form1 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBox_Firstname.Text) ||
                string.IsNullOrWhiteSpace(txtBox_Lastname.Text) ||
                string.IsNullOrWhiteSpace(txtBox_Email.Text) ||
                string.IsNullOrWhiteSpace(txtBox_Password.Text) ||
                string.IsNullOrWhiteSpace(txtBox_PassConfirm.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }


            // Retrieve user input
            string firstName = txtBox_Firstname.Text;
            string lastName = txtBox_Lastname.Text;
            string email = txtBox_Email.Text;
            string password = txtBox_Password.Text;
            string confirmPassword = txtBox_PassConfirm.Text;
            int maxID, newID;

            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if(!IsValidEmail(email))
            {
                MessageBox.Show("Please include an '@' and '.' in your email address.");
                return;
            }

            if (password.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters long.");
                return;
            }

            // Hash the password
            string passwordHash = HashPassword(password);

            // Check if email already exists in the database
            OracleCommand cmdCheckEmail = new OracleCommand();
            cmdCheckEmail.Connection = conn;
            cmdCheckEmail.CommandText = "SELECT COUNT(*) FROM Users WHERE Email = :email";
            cmdCheckEmail.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

            int emailCount = Convert.ToInt32(cmdCheckEmail.ExecuteScalar());
            if (emailCount > 0)
            {
                MessageBox.Show("This email is already registered.");
                return;
            }

            // Insert user details into the database
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();

            cmd.Connection = conn;
            cmd2.Connection = conn;

            cmd2.CommandText = "GetUsertID";
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

            cmd.CommandText = "INSERT INTO Users (USERID, FirstName, LastName, Email, PasswordHash, CreatedAt) " +
                              "VALUES (:newID, :firstName, :lastName, :email, :passwordHash, CURRENT_TIMESTAMP)";

            cmd.Parameters.Add("newID", newID);
            cmd.Parameters.Add("firstName", OracleDbType.Varchar2).Value = firstName;
            cmd.Parameters.Add("lastName", OracleDbType.Varchar2).Value = lastName;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("passwordHash", OracleDbType.Varchar2).Value = passwordHash;

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully.");

                    Form2 form2 = new Form2();  
                    form2.Show();
                    this.Hide();   
                }
                else
                {
                    MessageBox.Show("Failed to register user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string HashPassword(string password)
        {
            // Your password hashing logic here
            return password; // For demonstration, return the password as is
        }

        public static bool IsValidEmail(string email)
        {
            // Regular expression for validating email addresses
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            System.Windows.Forms.Application.Exit();
        }
    }
}

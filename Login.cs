using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airlines_Reservation
{
    public partial class Login : Form
    {
        Home f2 = new Home();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-5JD2522\SQLEXPRESS;Initial Catalog=Reservation db;Integrated Security=True");
            string query = "Select * from Admin where username = '"+ textUserName.Text.Trim()+"' and password = '"+ textPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon); 
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {

                MessageBox.Show("Welcome " + textUserName.Text);
                
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error...User name/Password incorrect!!");
                textUserName.Text = "";
                textPassword.Clear();
                textPassword.Focus();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

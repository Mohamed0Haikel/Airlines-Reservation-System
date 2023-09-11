using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines_Reservation
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        public void ClearForm()
        {
            //Clearing Form
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.Text = "";
            textBox1.Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation_dbEntities db = new Reservation_dbEntities();
            Tbl_Customer_Details CUS = new Tbl_Customer_Details 
            {
                CUS_firstname = textBox1.Text,
                CUS_surname = textBox3.Text,

                CUS_BirthDate = dateTimePicker1.Text,

                CUS_Email = textBox2.Text,

                CUS_Phone = textBox4.Text,

                Address = textBox5.Text
            };
            db.Tbl_Customer_Details.Add(CUS);

            db.SaveChanges();
            MessageBox.Show("Added Successfully.");


                ClearForm();
            
        }


    }
}
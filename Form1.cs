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
using Project.UIForms;

namespace Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            Sidepanel1.Height = button1.Height;
            Sidepanel1.Top = button1.Top;
            userControl111.BringToFront();
           /* try
            {
                string connectionstring;

                connectionstring = @"Data Source  = DESKTOP-AU9EQEH\ROHAANSQL; Initial Catalog  = Sample;
                                    Integrated Security = true";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                MessageBox.Show("Successsfull connection");

            }
            catch
            {
                MessageBox.Show("Not Successsfull connection");
            } */
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Member DM = new DueMember();
            
          
        }

        private void headerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Annoucement a = new Annoucement();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = button1.Height;
            Sidepanel1.Top = button1.Top;
            userControl111.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = button2.Height;
            Sidepanel1.Top = button2.Top;
            userControl21.BringToFront();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Sidepanel1.Height = button3.Height;
            Sidepanel1.Top = button3.Top;
            userControl31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = button4.Height;
            Sidepanel1.Top = button4.Top;
            userControl41.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = button5.Height;
            Sidepanel1.Top = button5.Top;
            userControl51.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = button6.Height;
            Sidepanel1.Top = button6.Top;
            userControl61.BringToFront();
        }
    }
}

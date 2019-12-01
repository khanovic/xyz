using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.InterFace;
using Project.UIForms;

namespace Project
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            
        }

      

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            AddStock stock = new AddStock();
            stock.Show();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            ViewStock stock = new ViewStock();
            stock.BringToFront();
            stock.Show();

        }
    }
}

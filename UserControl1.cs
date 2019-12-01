using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ProfitAnalysisForm F3 = new ProfitAnalysisForm();
            F3.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DueDateForm f1 = new DueDateForm();
            f1.Show();
        }
    }
}

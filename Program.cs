//using Project.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
     // public  SqlConnection con;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new LoginForm());
            Application.Run(new Home());
             //Application.Run(new InterFace.AddStock());
           
            DueMember DM = new DueMember();
            DM.OpenSqlConnection();
            DM.CheckDue();
            DM.CloseSqlConnection();

          /*  Member vip = new VIPMember();
            Member normal = new NormalMember();

             vip.Swim(); // ==> Vip can Swim
            normal.Swim(); // => Normal Cant Swim /*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ApplicationSftwrEngineering
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Mutex myLock = new Mutex(false, "mydomain.com myprogramname"))
            {
                if (myLock.WaitOne(3000, false))
                {
                    Application.Run(new Login());
                }
                else
                {
                    MessageBox.Show("Program already running", "There can be only one", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

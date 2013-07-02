using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkDiscoverer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mainView = new Form1();
            Object hans = new ControlCenter(mainView);
            //statements after the Run() will apparently never be reached. So make sure to place all nessecary code before it!
            Application.Run(mainView);


        }
    }
}

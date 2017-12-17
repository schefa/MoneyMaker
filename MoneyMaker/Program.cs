using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace MoneyMaker
{
    static class Program
    {

        public static Process PriorProcess()
        {
            Process current = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(current.ProcessName);
            foreach(Process p in procs)
            {
                if ((p.Id != current.Id) && (current.MainModule.FileName == p.MainModule.FileName))
                    return p;
            }
            return null;
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(PriorProcess() != null)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);         
            
            Application.Run(new FrmMain()); 
        }
    }
}

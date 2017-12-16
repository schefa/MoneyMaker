using MoneyMaker.Models.Database;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MoneyMaker.ViewModels
{
    public class DatabaseModel
    {
        protected DatabaseClassDataContext db;
        private SqlConnection connection;        

        private bool connectionState = false;
        public bool ConnectionState
        {
            get { return connectionState;  }
            private set { connectionState = value; }
        }

        /// <summary>
        /// Default constructor that generates the connection string
        /// </summary>
        public DatabaseModel()
        {
            String moneyMakerProcess = Process.GetCurrentProcess().ProcessName;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            // Checking if local server instance was selected, and there ain't more than one MoneyMaker process opened
            if (!(Process.GetProcesses().Count(p => p.ProcessName == moneyMakerProcess) > 1))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();

                // creating and starting a localDB instance version 12.0 coming with SQL LocalDB 2014
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "sqllocaldb.exe";
                startInfo.Arguments = "create MoneyMaker 12.0 -s";               

                Process.Start(startInfo);

            }

            using (connection = new SqlConnection(connectionString))
            {
                db = new DatabaseClassDataContext(connectionString);
                
                try
                {
                    connection.Open();
                    ConnectionState = true;
                }
                catch (SqlException)
                {
                    //MessageBox.Show(ex.Message);
                    ConnectionState = false;
                }
            }
        }
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMaker.Helpers
{
    [RunInstaller(true)]
    public partial class InstallHelper : System.Configuration.Install.Installer
    {
        public InstallHelper()
        {
            InitializeComponent();           
        }          

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            // saves the current install state
            base.Install(stateSaver);

            // adds the connectionString to the app.config
            setConnectionString();

            // encrypts the connectionString in the app.config
            encryptConnectionString(true);
        }

        // saves the state of changes after the install of the software
        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);            

            //try
            //{
            //    Directory.SetCurrentDirectory(Path.GetDirectoryName
            //    (Assembly.GetExecutingAssembly().Location));
            //    Process.Start(Path.GetDirectoryName(
            //      Assembly.GetExecutingAssembly().Location) + "\\MoneyMaker.exe");
            //}
            //catch
            //{
            //    // Do nothing... 
            //}
        }

        // saves the state before the install of the software
        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        // saves the state after the uninstall of the software
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }

        private void setConnectionString()
        {
            // connect connectionString
            var map = new ExeConfigurationFileMap();
            map.ExeConfigFilename =
                Context.Parameters["assemblypath"] + ".config";
            var config =
                ConfigurationManager.OpenMappedExeConfiguration(
                    map, ConfigurationUserLevel.None);


            // update connectionString
            var connectionString = config.ConnectionStrings;
            if (Context.Parameters["SourceTyp"] == "1") // Local
            {
                connectionString.ConnectionStrings["ConnectionString"].ConnectionString = @"Data Source = (LocalDB)\MoneyMaker; " +
                                                                                         $@"AttachDbFilename = {Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\MoneyMaker\LocalDatabase.mdf; Integrated Security = True; MultipleActiveResultSets=True";
            }
            else if (Context.Parameters["SourceTyp"] == "2") // SQL Server
            {
                connectionString.ConnectionStrings["ConnectionString"].ConnectionString = $"Data Source = {Context.Parameters["DataSource"]}; " +
                                                                                          $"Initial Catalog = {Context.Parameters["InitialCatalog"]}; " +
                                                                                           "Integrated Security = False; " +
                                                                                          $"User ID = {Context.Parameters["UserID"]}; " +
                                                                                          $"Password = {Context.Parameters["Password"]}; " +
                                                                                           "Pooling = False; TrustServerCertificate = False; MultipleActiveResultSets=True";
            }

            // save connectionString 
            config.Save();
        }

        public void encryptConnectionString(bool encrypt)
        {
            Configuration configuration = null;
            try
            {
                // Open the configuration file and retrieve the connectionStrings section.
                var map = new ExeConfigurationFileMap();
                map.ExeConfigFilename = Context.Parameters["assemblypath"] + ".config";
                configuration =
                    ConfigurationManager.OpenMappedExeConfiguration(
                        map, ConfigurationUserLevel.None);
                
                ConnectionStringsSection configSection = configuration.GetSection("connectionStrings") as ConnectionStringsSection;
                if ((!(configSection.ElementInformation.IsLocked)) && (!(configSection.SectionInformation.IsLocked)))
                {
                    if (encrypt && !configSection.SectionInformation.IsProtected)
                    {
                        //this line will encrypt the file
                        configSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    }

                    if (!encrypt && configSection.SectionInformation.IsProtected)//encrypt is true so encrypt
                    {
                        //this line will decrypt the file. 
                        configSection.SectionInformation.UnprotectSection();
                    }
                    //re-save the configuration file section
                    configSection.SectionInformation.ForceSave = true;
                   
                    // Save the current configuration
                    configuration.Save();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

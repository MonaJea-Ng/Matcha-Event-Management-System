using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ADET_sample
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            

            ApplicationConfiguration.Initialize();
            Application.Run(new Main_Page());
        }
    }


    public class DatabaseConnection
    {
        public static MySqlConnection GetConnection()
        {

            string connstring = "server = 127.0.0.1; Port=3307;uid=root;pwd=administrator;database=matcha"; // Adjust credentials as needed
            return new MySqlConnection(connstring);
        }
    }
            
}
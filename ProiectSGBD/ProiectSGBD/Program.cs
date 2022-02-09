using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectSGBD
{
    public static class Global
    {
        public static string stringConectare = @"Data Source = GEORGII\SQLSERVER2019; Initial Catalog = dbStudentHope; Integrated Security = SSPI";
        public static SqlConnection con;
        public static SqlDataAdapter daJoburi;
        public static SqlDataAdapter daJoburiAngajat;
        public static SqlDataAdapter daAplicatiiStudent;
        public static SqlDataAdapter daJoburiDepartament;
        public static SqlDataAdapter daJoburiOras; 
        public static SqlDataAdapter daJoburiStudii;
        public static SqlDataAdapter daAplicatiiJob;
        public static SqlDataAdapter daJoburiCautate;
        public static DataSet ds;
        public static SqlCommandBuilder cb;
    }

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using OpenQA.Selenium;
using Xamarin.Essentials;
using System.Data.SqlClient;

namespace ProiectSGBD
{
    public partial class Aplicari : Form
    {
     
        public Aplicari()
        {
            InitializeComponent();
        }

        private void Aplicari_Load(object sender, EventArgs e)
        {
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
            Global.ds.Clear();
            Global.daAplicatiiJob = new System.Data.SqlClient.SqlDataAdapter("select Nume,Gen, A.Studii,Email,Cv,idApp from tStudenti as A inner join tAplicatii as B on A.Email = B.EmailSt  inner join tJoburi as C on B.idJob = C.idJob where B.idJob = '" + ContA.id + "'", Global.con);
            Global.daAplicatiiJob.Fill(Global.ds,"AplicatiiJob");
            dataGridView4.DataSource = Global.ds;
            dataGridView4.DataMember = "AplicatiiJob";
            try
            {
                dataGridView4.Columns[4].Visible = false;
                dataGridView4.Columns[5].Visible = false;
            }
            catch { }

        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string url = dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString();
            System.Diagnostics.Process.Start(url);
            string idApp= dataGridView4.Rows[e.RowIndex].Cells[5].Value.ToString();
            string insert= "update tAplicatii set StatusApp = 'Citit' where idApp= '"+idApp+"'";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(insert, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }

        private void Aplicari_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContA contA = new ContA();
            contA.Show();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectSGBD
{
    public partial class Logare : Form
    {

        public static int logat = 0;
        public Logare()
        {
            InitializeComponent();
        }
        private void Logare_Load(object sender, EventArgs e)
        {
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inregistrare inregistrare = new Inregistrare();
            inregistrare.ShowDialog();
           
        }

        private void bCont_Click(object sender, EventArgs e)
        {

            if (rbAngajator.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Global.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ps_existaAngajat";
                SqlParameter p1 = new SqlParameter();
                p1.Value = tbEmail.Text;
                p1.ParameterName = "@email";
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter();
                p2.Value = tbParola.Text;
                p2.ParameterName = "@parola";
                cmd.Parameters.Add(p2);
                Global.con.Open();
                
                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("Email sau parolă incorectă!");
                    Global.con.Close();
                }
                else
                {
                    ContA.Angajat = cmd.ExecuteScalar().ToString();
                    Global.con.Close();
                    logat = 1;
                    this.Visible = false;
                    ContA contA = new ContA();
                    contA.Show();
                }

            }
            else if (rbStudent.Checked)
            {
                string stud = "select * from tStudenti where Email='"+tbEmail.Text+"' and Parola= '"+tbParola.Text+"'";
                Global.con.Open();
                SqlCommand cmd = new SqlCommand(stud, Global.con);
                if (cmd.ExecuteScalar() == null)
                    MessageBox.Show("Nu există acest cont!");
                else
                {
                    ContS.Student = tbEmail.Text;
                    logat = 1;
                    this.Visible = false;
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                Global.con.Close();
            }
            else MessageBox.Show("Seletati tipul de conectare!");


        }

        private void Logare_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            if (this.DialogResult == DialogResult.Cancel)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
        }
    }

}



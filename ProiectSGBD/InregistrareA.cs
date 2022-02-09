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
    public partial class InregistrareA : Form
    {
        
        public InregistrareA()
        {
            InitializeComponent();

        }

        private void InregistrareA_Load(object sender, EventArgs e)
        {
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bCont_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirma.Text))
            {
                MessageBox.Show("Vă rugăm introduceți numele firmei!");
                return;
            }
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Vă rugăm introduceți email-ul!");
                return;
            }
            if (string.IsNullOrEmpty(tbParola.Text))
            {
                MessageBox.Show("Vă rugăm introduceți parola!");
                return;
            }
            try
            {

                string insert = "insert into tAngajati(Firma,Parola,Email) values ('" + tbFirma.Text + "','" + tbParola.Text + "','" + tbEmail.Text + "')";
                ContA.Angajat = tbFirma.Text;
                Global.con.Open();
                SqlCommand cmd = new SqlCommand(insert, Global.con);
                cmd.ExecuteNonQuery();
                Global.con.Close();
                Logare.logat = 1;
                this.Visible = false;
                ContA contA = new ContA();
                contA.Show();
                
            }
            catch {
                MessageBox.Show("Acest cont exisă deja! Vă rugăm conectativă la contul dumneavoastră!");
            } 


           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Logare logare = new Logare();
            logare.ShowDialog();
            this.Visible = false;
        }
        private void InregistrareA_FormClosing(object sender, FormClosingEventArgs e)
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

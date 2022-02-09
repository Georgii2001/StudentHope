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
    public partial class InregistrareS : Form
    {
        string cv, poza,gen;
        public InregistrareS()
        {
            InitializeComponent();
        }

        private void InregistrareS_Load(object sender, EventArgs e)
        {
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (var item in Enum.GetValues(typeof(ProgramStudii))) cbProgramStudii.Items.Add(item);
 
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Logare logare = new Logare();
            logare.ShowDialog();
            this.Visible = false;
        }

        private void bCV_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.pdf;)|*.pdf;";
            if (open.ShowDialog() == DialogResult.OK)
                cv = open.FileName.ToString();
        }

        private void InregistrareS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inregistrare f = new Inregistrare();
            f.Show();
        }

        private void InregistrareS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            if (this.DialogResult == DialogResult.Cancel)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
        }

        private void BPoza_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;.jpg;)|*.jpeg;.jpg;";
            if (open.ShowDialog() == DialogResult.OK)
                poza = open.FileName.ToString();
        }
        private void bCont_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNume.Text))
            {
                MessageBox.Show("Vă rugăm introduceți numele!");
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
            if (string.IsNullOrEmpty(cbProgramStudii.Text))
            {
                MessageBox.Show("Vă rugăm introduceți programul de studii!");
                return;
            }
            if (string.IsNullOrEmpty(poza))
            {
                MessageBox.Show("Vă rugăm introduceți parola!");
                return;
            }
            if (string.IsNullOrEmpty(cv))
            {
                MessageBox.Show("Vă rugăm introduceți cv-ul!");
                return;
            }
            if (rbFeminin.Checked)
                gen = rbFeminin.Text;
            else if (rbMasculin.Checked)
                gen = rbMasculin.Text;
            
            try
            {
                string insert = "insert into tStudenti(Nume,Parola,Email,Studii,Gen,Poza,Cv) values ('" + tbNume.Text + "','" + tbParola.Text + "','" + tbEmail.Text + "','" + cbProgramStudii.Text + "','" + gen + "','" + poza + "','" + cv +"')";
                ContS.Student = tbEmail.Text;
                Global.con.Open();
                SqlCommand cmd = new SqlCommand(insert, Global.con);
                cmd.ExecuteNonQuery();
                Global.con.Close();
                this.Visible = false;
                Logare.logat = 1;
                Form1 f1 = new Form1();
                f1.Show();

            }
            catch 
            { 
                Global.con.Close();
                MessageBox.Show("Acest cont exisă deja! Vă rugăm conectativă la contul dumneavoastră!");
            }

        }

    }
}

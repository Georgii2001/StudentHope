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
    public partial class ContS : Form
    {
        public static string Student;

        public void updateGrid()
        {
            Global.ds.Clear();
            Global.daAplicatiiStudent = new System.Data.SqlClient.SqlDataAdapter("select idApp as ID,Firma, Post,StatusApp, DataApp  from tAplicatii as A inner join tJoburi as B on A.idJob= B.idJob where EmailSt= '" + ContS.Student + "'", Global.con);
            Global.daAplicatiiStudent.Fill(Global.ds, "AplicatiiStudent");
            dataGridView3.DataSource = Global.ds;
            dataGridView3.DataMember = "AplicatiiStudent";
        }
        public ContS()
        {
            InitializeComponent();
        }

        private void ContS_Load(object sender, EventArgs e)
        {   
            updateGrid();
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStudent.Image = Image.FromFile(Form1.poza);
            pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            contulMeu.Text = Form1.ContulMeu.Text;
           
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            string id = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            if (id == null)
                MessageBox.Show("Niciun rand selectat!");
            else {
                string insert = "  delete from tAplicatii where idApp= '" + int.Parse(id) + "'";
                Global.con.Open();
                SqlCommand cmd = new SqlCommand(insert, Global.con);
                cmd.ExecuteNonQuery();
                Global.con.Close();
                MessageBox.Show("Anuntul tău a fost șters cu succes!");
                updateGrid();
               
            }
        }


        private void tbparolaVeche_Click(object sender, EventArgs e)
        {
            tbparolaVeche.Text = "";
        }

        private void tbparolaNoua_Click(object sender, EventArgs e)
        {
            tbparolaNoua.Text = "";
        }


        private void Deconectare_Click(object sender, EventArgs e)
        {

            Logare.logat = 0;
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.Show();
          
        }
        int x = 0;

        private void tbparolaNoua_MouseLeave(object sender, EventArgs e)
        {
            if (tbparolaNoua.Text != "")
               if (x==1){

                string insert = "   update tStudenti set Parola= '"+ tbparolaNoua +"' where Email= '" + Student+ "'";
                Global.con.Open();
                SqlCommand cmd = new SqlCommand(insert, Global.con);
                cmd.ExecuteNonQuery();
                Global.con.Close();
                MessageBox.Show("Parola schimbată cu succes!");
               }
                else MessageBox.Show("Parola curenta nu este corecta!");
        }

        private void stergereContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insert = "delete from tStudenti where Email= '" + Student + "'";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(insert, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            Logare.logat = 0;
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.Show();
        }

        private void modificăParolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbparolaNoua.Text = "Parolă nouă";
            tbparolaVeche.Text = "Parolă curentă";
        }

        private void tbparolaVeche_MouseLeave(object sender, EventArgs e)
        {
            string insert = "select parola from tStudenti where Email= '" + Student + "'";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(insert, Global.con);
            string parola = cmd.ExecuteScalar().ToString();
            Global.con.Close();
            if (tbparolaVeche.Text != parola)
            {
                MessageBox.Show("Parola curenta nu este corecta!");
                tbparolaVeche.Text = "";
            }
            else x = 1;
        }

        private void ContS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void joburiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}

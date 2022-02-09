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
    public partial class Form1 : Form
    {

        DataView dv;
        DataTable dt;
        public static  string poza;

        public Form1()
        {
            InitializeComponent();
        }
        public  void updateGrid() {
            Global.ds.Clear();
            Global.daJoburi = new System.Data.SqlClient.SqlDataAdapter("select * from tJoburi", Global.con);
            Global.daJoburi.Fill(Global.ds, "Joburi");
            dataGridView1.DataSource = Global.ds;
            dataGridView1.DataMember = "Joburi";
        }

        public  void conectare(){
            if (Logare.logat == 0)
            {
                meniuForm1.Visible = false;
                bLogare.Visible = true;
                bInregistrare.Visible = true;
                pbStudent.Visible = false;
                
            }
            else
            {
                meniuForm1.Visible = true;
                Global.con.Open();
                SqlCommand cmd = new SqlCommand("Select Nume from tStudenti where Email= '" + ContS.Student + "'", Global.con);
                ContulMeu.Text = cmd.ExecuteScalar().ToString();
                pbStudent.Visible = true;
                cmd = new SqlCommand("Select Poza from tStudenti where Email= '" + ContS.Student + "'", Global.con);
                poza = cmd.ExecuteScalar().ToString();
                Global.con.Close();
                pbStudent.Image = Image.FromFile(poza);
                pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                bLogare.Visible = false;
                bInregistrare.Visible = false;
            }
        }
        private void Logare_Load(object sender, EventArgs e)
        {
            
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (var item in Enum.GetValues(typeof(Departament)))  cbDepartament.Items.Add(item);
            foreach (var item in Enum.GetValues(typeof(ProgramStudii))) cbProgramStudii.Items.Add(item);
            foreach (var item in Enum.GetValues(typeof(Oras))) cbOras.Items.Add(item);

            Global.con = new System.Data.SqlClient.SqlConnection(Global.stringConectare);
            Global.ds = new DataSet();
            Global.ds.Clear(); 
            updateGrid();
            conectare();
            dt = Global.ds.Tables["Joburi"];
        }

        private void bInregistrare_Click(object sender, EventArgs e)
        {
            Inregistrare inregistrare = new Inregistrare();
            this.Visible = false;
            inregistrare.ShowDialog();
           

        }
        private void bLogare_Click(object sender, EventArgs e)
        {
           Logare logare = new Logare();
           this.Visible = false;
           logare.ShowDialog();
      
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Anunt job = new Anunt();
            job.idToolStripMenuItem.Text =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            job.firmaToolStripMenuItem.Text="Firmă: " +dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            job.departamentToolStripMenuItem.Text ="Departament: "+ dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            job.studiiToolStripMenuItem.Text ="Program de studii: "+ dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            job.orasToolStripMenuItem.Text ="Oraș: "+ dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            job.lPost.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            job.rtbDescriere.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            job.Show();
        }

        private void joburileMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ContS contS = new ContS();
            contS.ShowDialog();
        }

        private void modificăParolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbparolaNoua.Text = "Parolă nouă";
            tbparolaVeche.Text = "Parolă curentă";
        }

        private void Deconectare_Click(object sender, EventArgs e)
        {
            Logare.logat = 0;
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.Show();
        }

        private void stergereContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insert = "delete from tStudenti where Email= '" + ContS.Student + "'";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(insert, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            Logare.logat = 0;
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.Show();
        }

        private void tbparolaVeche_Click(object sender, EventArgs e)
        {
            tbparolaVeche.Text = "";
        }

        private void tbparolaNoua_Click(object sender, EventArgs e)
        {
            tbparolaNoua.Text = "";
        }
        int x = 0;
        private void tbparolaNoua_MouseLeave(object sender, EventArgs e)
        {
            if (tbparolaNoua.Text != "")
                if (x == 1)
                {

                    string insert = "   update tStudenti set Parola= '" + tbparolaNoua + "' where Email= '" + ContS.Student + "'";
                    Global.con.Open();
                    SqlCommand cmd = new SqlCommand(insert, Global.con);
                    cmd.ExecuteNonQuery();
                    Global.con.Close();
                    MessageBox.Show("Parola schimbată cu succes!");
                }
                else MessageBox.Show("Parola curenta nu este corecta!");
        }

        private void tbparolaVeche_MouseLeave(object sender, EventArgs e)
        {
            string insert = "select parola from tStudenti where Email= '" + ContS.Student + "'";
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

        private void cbDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ds.Clear();
            string Dep = cbDepartament.SelectedItem.ToString();
            Global.daJoburiDepartament = new System.Data.SqlClient.SqlDataAdapter("select * from tJoburi where Departament= '" + Dep + "'", Global.con);
            Global.daJoburiDepartament.Fill(Global.ds, "JoburiDepartament");
            dataGridView1.DataSource = Global.ds;
            dataGridView1.DataMember = "JoburiDepartament";
        }

        private void cbProgramStudii_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Studii = cbProgramStudii.SelectedItem.ToString();
            dv = new DataView(dt, "Studii = '"+Studii +"'", null, DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dv;
          
        }
      
        /*
        private void cbProgramStudii_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ds.Clear();
            string Studii = cbProgramStudii.SelectedItem.ToString();
            Global.daJoburiStudii = new System.Data.SqlClient.SqlDataAdapter("select * from tJoburi where Studii= '" + Studii + "'", Global.con);
            Global.daJoburiStudii.Fill(Global.ds, "JoburiStudii");
            dataGridView1.DataSource = Global.ds;
            dataGridView1.DataMember = "JoburiStudii";
        }
        */
        private void cbOras_SelectedIndexChanged(object sender, EventArgs e)
        {
             Global.ds.Clear();
             string Oras = cbOras.SelectedItem.ToString();
             Global.daJoburiOras = new System.Data.SqlClient.SqlDataAdapter("select * from tJoburi where Oras= '" + Oras + "'", Global.con);
             Global.daJoburiOras.Fill(Global.ds, "JoburiOras");
             dataGridView1.DataSource = Global.ds;
             dataGridView1.DataMember = "JoburiOras";
        }

        private void bCautare_Click(object sender, EventArgs e)
        {
            Global.ds.Clear();
            string insert = " select * from tJoburi where Post like '%" + tbCautare.Text + "%' or Descriere like '%" + tbCautare.Text + "%'";
            Global.daJoburiCautate = new System.Data.SqlClient.SqlDataAdapter(insert, Global.con);
            Global.daJoburiCautate.Fill(Global.ds, "JoburiCautate");
            dataGridView1.DataSource = Global.ds;
            dataGridView1.DataMember = "JoburiCautate";
        }
    }
}

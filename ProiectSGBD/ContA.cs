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
    public partial class ContA : Form
    {
  
   
        public static string Angajat;

        public ContA()
        {
            InitializeComponent();
        }

        public void updateGrid() {
            Global.ds.Clear();
            Global.daJoburiAngajat = new System.Data.SqlClient.SqlDataAdapter("select * from tJoburi where firma= '" + Angajat + "'", Global.con);
            Global.daJoburiAngajat.Fill(Global.ds, "JoburiAngajat");
            dataGridView2.DataSource = Global.ds;
            dataGridView2.DataMember = "JoburiAngajat";
        }
        private void ContA_Load(object sender, EventArgs e)
        {
            updateGrid();
            Global.cb = new SqlCommandBuilder(Global.daJoburiAngajat);
            Global.daJoburiAngajat.InsertCommand = Global.cb.GetInsertCommand();
            Global.daJoburiAngajat.DeleteCommand = Global.cb.GetDeleteCommand();
            Global.daJoburiAngajat.UpdateCommand = Global.cb.GetUpdateCommand();
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
           
            contulMeu.Text = Angajat;
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            AddJob addJob = new AddJob();
            foreach (object t in addJob.Controls)
            {   
                if (t.GetType() == typeof(TextBox))    
                    ((TextBox)t).Text="";
                if (t.GetType() == typeof(RichTextBox))
                    ((RichTextBox)t).Text = "";
                if (t.GetType() == typeof(ComboBox))
                    ((ComboBox)t).Text = "";
                if (t.GetType() == typeof(ProgressBar))
                    ((ProgressBar)t).Value = 0 ;

            }
            this.Visible = false ;
            addJob.bAdd.Text = "Adaugă";
            addJob.ShowDialog();

        }
        public static string dep, oras, studii,id,post,descriere;

        private void modificăParolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbparolaNoua.Text = "Parolă nouă";
            tbparolaVeche.Text = "Parolă curentă";
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

                    string insert = "   update tAngajati set Parola= '" + tbparolaNoua + "' where Firma= '" + Angajat + "'";
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
            string insert = "select parola from tAngajati where Firma= '" + Angajat + "'";
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

        private void bAplicari_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Aplicari app = new Aplicari();
            app.Show();

        }

        private void bExport_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["JoburiAngajat"].WriteXml(@"D:\UPIT\II\SGBD\ProiectSGBD\ExportXML.xml");
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            SqlTransaction tr = Global.con.BeginTransaction();
            Global.daJoburiAngajat.InsertCommand.Transaction = tr;
            Global.daJoburiAngajat.DeleteCommand.Transaction = tr;
            Global.daJoburiAngajat.UpdateCommand.Transaction = tr;
            DataTable t = Global.ds.Tables["JoburiAngajat"].GetChanges();
            try
            {
                if (t != null)
                {
                    Global.daJoburiAngajat.Update(t);
                    Global.ds.Tables["JoburiAngajat"].AcceptChanges();
                    tr.Commit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Salvare anulata!" + ex);
                tr.Rollback();
                Global.ds.Tables["JoburiAngajat"].RejectChanges();
            }
            finally
            {
                Global.con.Close();
            }
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
            string insert = "delete from tAngajati where Firma= '" + Angajat + "'";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(insert, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            Logare.logat = 0;
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id= dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            dep = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            studii = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            oras = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            post= dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            descriere = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
          
        }

        private void bModifica_Click(object sender, EventArgs e)
        {
            AddJob addJob = new AddJob();
            foreach (var item in Enum.GetValues(typeof(Departament))) addJob.cbDepartament.Items.Add(item);
            foreach (var item in Enum.GetValues(typeof(ProgramStudii))) addJob.cbProgramStudii.Items.Add(item);
            foreach (var item in Enum.GetValues(typeof(Oras))) addJob.cbOras.Items.Add(item);
            addJob.cbDepartament.SelectedIndex = addJob.cbDepartament.FindString(dep);
            addJob.cbProgramStudii.SelectedIndex = addJob.cbProgramStudii.FindString(studii);
            addJob.cbOras.SelectedIndex = addJob.cbOras.FindString(oras);
            addJob.tbId.Text = id;
            addJob.tbPost.Text = post;
            addJob.rtbDescriere.Text = descriere;
            addJob.bAdd.Text ="Modifică";
            this.Visible = false;
            addJob.ShowDialog();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            AddJob addJob = new AddJob();
            string insert = "  delete from tJoburi where idJob= '"+ id + "'";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(insert, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            MessageBox.Show("Anuntul tău a fost șters cu succes!");
            updateGrid();
           
        }
    }
}

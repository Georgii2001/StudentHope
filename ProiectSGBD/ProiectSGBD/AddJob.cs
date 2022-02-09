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
    public partial class AddJob : Form
    { 

        public AddJob()
        {
            InitializeComponent();
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            rtbDescriere.MaxLength = 1499;
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
            if (bAdd.Text == "Adaugă")
            {
                foreach (var item in Enum.GetValues(typeof(Departament))) cbDepartament.Items.Add(item);
                foreach (var item in Enum.GetValues(typeof(ProgramStudii))) cbProgramStudii.Items.Add(item);
                foreach (var item in Enum.GetValues(typeof(Oras))) cbOras.Items.Add(item);

            }


            SqlCommand cmd = new SqlCommand(" select max(idJob) from tJoburi", Global.con);
            Global.con.Open();
            int id;
            try
            {
                 id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            }
            catch {
                 id = 1;
            }
      
            tbId.Text = id.ToString();
            Global.con.Close();
    
            tbFirma.Text = ContA.Angajat;

        }


        private void bAdd_Click(object sender, EventArgs e)
        {

             
            if (string.IsNullOrEmpty(tbPost.Text))
            {
                MessageBox.Show("Vă rugăm introduceți postul!");
                return;
            }
            if (string.IsNullOrEmpty(cbDepartament.Text))
            {
                MessageBox.Show("Vă rugăm selectati departamentul!");
                return;
            }
            if (string.IsNullOrEmpty(cbOras.Text))
            {
                MessageBox.Show("Vă rugăm selectati orasul!");
                return;
            }
            if (string.IsNullOrEmpty(cbProgramStudii.Text))
            {
                MessageBox.Show("Vă rugăm introduceți programul de studii dorit!");
                return;
            }

          
            if (bAdd.Text == "Adaugă")
            {
                
                string insert = "insert into tJoburi(idJob,Firma,Departament,Studii,Oras,Post,Descriere) values ('" + tbId.Text + "','" + tbFirma.Text + "','" + cbDepartament.Text + "','" + cbProgramStudii.Text + "','" + cbOras.Text + "','" + tbPost.Text +  "','" + rtbDescriere.Text + "')";
                try
                {
                    Global.con.Open();
                    SqlCommand cmd = new SqlCommand(insert, Global.con);
                    cmd.ExecuteNonQuery();
                    Global.con.Close();
                    MessageBox.Show("Anuntul tău a fost adăugat cu succes!");
                    this.Close();
                }
                catch(ArgumentException x)
                { MessageBox.Show(x.ToString()); }

            }
            else {
                
                string insert = "UPDATE tJoburi set Departament='" + cbDepartament.Text + "', Studii='" + cbProgramStudii.Text + "',Oras= '" + cbOras.Text + "',Post='" + tbPost.Text + "',Descriere='" + rtbDescriere.Text + "' WHERE idJob= '"+ContA.id +"'";
                Global.con.Open();
                SqlCommand cmd = new SqlCommand(insert, Global.con);
                cmd.ExecuteNonQuery();
                Global.con.Close();
                MessageBox.Show("Anuntul tău a fost modificat cu succes!");
                this.Close();
            }
            
        }

        private void AddJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContA contA = new ContA();
            contA.Show();
        }

    }
}

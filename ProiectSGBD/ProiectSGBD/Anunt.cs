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
    public partial class Anunt : Form
    {
        public Anunt()
        {
            InitializeComponent();
        }

        private void Anunt_Load(object sender, EventArgs e)
        {
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bAplica_Click(object sender, EventArgs e)
        {
            if (Logare.logat == 1)
            {
                string insert = "select Studii from tStudenti where Email = '" + ContS.Student + "'";
                SqlCommand cmd = new SqlCommand(insert, Global.con);
                string insert1 = "select Studii from tJoburi where idJob = '" + idToolStripMenuItem + "'";
                SqlCommand cmd1 = new SqlCommand(insert1, Global.con);
                Global.con.Open();
                if (cmd.ExecuteScalar().ToString() == cmd1.ExecuteScalar().ToString())
                {
                    cmd = new SqlCommand(" select max(idApp) from tAplicatii", Global.con);
                   // Global.con.Open();
                    int id;

                    try
                    {
                        id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                    }
                    catch
                    {
                        id = 1;
                    }
                    string apl = "select * from tAplicatii where EmailSt='" + ContS.Student + "' and idJob= '" + idToolStripMenuItem.Text + "'";
                    insert = "insert into tAplicatii(idApp,idJob,EmailSt,StatusApp,DataApp) values ('" + id + "','" + idToolStripMenuItem.Text + "','" + ContS.Student + "','Necitit',GETDATE())";
                    cmd = new SqlCommand(apl, Global.con);
                    if (cmd.ExecuteScalar() == null)
                    {
                        cmd = new SqlCommand(insert, Global.con);
                        cmd.ExecuteNonQuery();
                       // Global.con.Close();
                        MessageBox.Show("Ați aplicat cu succes!");
                    }
                    else { MessageBox.Show("Ați aplicat deja la acest anunț!"); }
                }
                else {
                    MessageBox.Show("Nu te potrivesti criteriilor de selectie! Ne pare rau!");
                }
            }
            else {
                MessageBox.Show("Pentru a aplica este nevoie să fiți conectat la un cont de student!");
            }
            Global.con.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectSGBD
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            pbicon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InregistrareA inregistrareA = new InregistrareA();
            this.Visible = false;
            inregistrareA.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InregistrareS inregistrareS = new InregistrareS();
            this.Visible=false;
            inregistrareS.ShowDialog();
            
        }

        private void Inregistrare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

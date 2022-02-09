
namespace ProiectSGBD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bLogare = new System.Windows.Forms.Button();
            this.bInregistrare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbDepartament = new System.Windows.Forms.ToolStripComboBox();
            this.cbProgramStudii = new System.Windows.Forms.ToolStripComboBox();
            this.cbOras = new System.Windows.Forms.ToolStripComboBox();
            this.tbCautare = new System.Windows.Forms.TextBox();
            this.bCautare = new System.Windows.Forms.Button();
            this.meniuForm1 = new System.Windows.Forms.MenuStrip();
            ContulMeu = new System.Windows.Forms.ToolStripMenuItem();
            this.joburileMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.modificăParolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbparolaVeche = new System.Windows.Forms.ToolStripTextBox();
            this.tbparolaNoua = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Deconectare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.pbicon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.menu.SuspendLayout();
            this.meniuForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "StudentHope";
            // 
            // bLogare
            // 
            this.bLogare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.bLogare.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.bLogare.Location = new System.Drawing.Point(919, 25);
            this.bLogare.Name = "bLogare";
            this.bLogare.Size = new System.Drawing.Size(163, 52);
            this.bLogare.TabIndex = 3;
            this.bLogare.Text = "Logare";
            this.bLogare.UseVisualStyleBackColor = false;
            this.bLogare.Click += new System.EventHandler(this.bLogare_Click);
            // 
            // bInregistrare
            // 
            this.bInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.bInregistrare.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInregistrare.Location = new System.Drawing.Point(708, 25);
            this.bInregistrare.Name = "bInregistrare";
            this.bInregistrare.Size = new System.Drawing.Size(163, 52);
            this.bInregistrare.TabIndex = 4;
            this.bInregistrare.Text = "Înregistrare";
            this.bInregistrare.UseVisualStyleBackColor = false;
            this.bInregistrare.Click += new System.EventHandler(this.bInregistrare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(59, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alege anunturile potrivite pentru tine si nu ezita sa aplici : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.dataGridView1.Location = new System.Drawing.Point(62, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 353);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.pbRefresh);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 38);
            this.panel1.TabIndex = 8;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = global::ProiectSGBD.Properties.Resources.refresh_1627545_1520850;
            this.pbRefresh.Location = new System.Drawing.Point(626, 3);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(47, 32);
            this.pbRefresh.TabIndex = 1;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Poor Richard", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.cbDepartament,
            this.cbProgramStudii,
            this.cbOras});
            this.menu.Location = new System.Drawing.Point(33, 3);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(574, 30);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip2";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.fToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.fToolStripMenuItem.Text = "Filtre:  ";
            // 
            // cbDepartament
            // 
            this.cbDepartament.AutoToolTip = true;
            this.cbDepartament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.cbDepartament.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.cbDepartament.Name = "cbDepartament";
            this.cbDepartament.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbDepartament.Size = new System.Drawing.Size(156, 26);
            this.cbDepartament.Text = " Departament";
            this.cbDepartament.SelectedIndexChanged += new System.EventHandler(this.cbDepartament_SelectedIndexChanged);
            // 
            // cbProgramStudii
            // 
            this.cbProgramStudii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.cbProgramStudii.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.cbProgramStudii.Name = "cbProgramStudii";
            this.cbProgramStudii.Size = new System.Drawing.Size(195, 26);
            this.cbProgramStudii.Text = " Program de studiu";
            this.cbProgramStudii.SelectedIndexChanged += new System.EventHandler(this.cbProgramStudii_SelectedIndexChanged);
            // 
            // cbOras
            // 
            this.cbOras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.cbOras.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.cbOras.Name = "cbOras";
            this.cbOras.Size = new System.Drawing.Size(121, 26);
            this.cbOras.Text = "Oraș";
            this.cbOras.SelectedIndexChanged += new System.EventHandler(this.cbOras_SelectedIndexChanged);
            // 
            // tbCautare
            // 
            this.tbCautare.Location = new System.Drawing.Point(62, 196);
            this.tbCautare.Name = "tbCautare";
            this.tbCautare.Size = new System.Drawing.Size(831, 22);
            this.tbCautare.TabIndex = 9;
            // 
            // bCautare
            // 
            this.bCautare.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Bold);
            this.bCautare.Location = new System.Drawing.Point(889, 195);
            this.bCautare.Name = "bCautare";
            this.bCautare.Size = new System.Drawing.Size(164, 23);
            this.bCautare.TabIndex = 10;
            this.bCautare.Text = "Caută intership";
            this.bCautare.UseVisualStyleBackColor = true;
            this.bCautare.Click += new System.EventHandler(this.bCautare_Click);
            // 
            // meniuForm1
            // 
            this.meniuForm1.BackColor = System.Drawing.Color.White;
            this.meniuForm1.Dock = System.Windows.Forms.DockStyle.None;
            this.meniuForm1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.meniuForm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ContulMeu});
            this.meniuForm1.Location = new System.Drawing.Point(864, 30);
            this.meniuForm1.Name = "meniuForm1";
            this.meniuForm1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.meniuForm1.Size = new System.Drawing.Size(139, 38);
            this.meniuForm1.TabIndex = 20;
            this.meniuForm1.Text = "menuStrip1";
            // 
            // ContulMeu
            // 
            ContulMeu.BackColor = System.Drawing.Color.White;
            ContulMeu.Checked = true;
            ContulMeu.CheckState = System.Windows.Forms.CheckState.Checked;
            ContulMeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joburileMeleToolStripMenuItem,
            this.toolStripSeparator3,
            this.modificăParolaToolStripMenuItem,
            this.toolStripSeparator1,
            this.Deconectare,
            this.toolStripSeparator2,
            this.stergereContToolStripMenuItem});
            ContulMeu.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            ContulMeu.MergeIndex = 0;
            ContulMeu.Name = "ContulMeu";
            ContulMeu.Padding = new System.Windows.Forms.Padding(5);
            ContulMeu.Size = new System.Drawing.Size(129, 34);
            ContulMeu.Text = "Contul meu";
            // 
            // joburileMeleToolStripMenuItem
            // 
            this.joburileMeleToolStripMenuItem.Name = "joburileMeleToolStripMenuItem";
            this.joburileMeleToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.joburileMeleToolStripMenuItem.Text = "Aplicările mele";
            this.joburileMeleToolStripMenuItem.Click += new System.EventHandler(this.joburileMeleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
            // 
            // modificăParolaToolStripMenuItem
            // 
            this.modificăParolaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbparolaVeche,
            this.tbparolaNoua});
            this.modificăParolaToolStripMenuItem.MergeIndex = 0;
            this.modificăParolaToolStripMenuItem.Name = "modificăParolaToolStripMenuItem";
            this.modificăParolaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.modificăParolaToolStripMenuItem.Text = "Modifică parola";
            this.modificăParolaToolStripMenuItem.Click += new System.EventHandler(this.modificăParolaToolStripMenuItem_Click);
            // 
            // tbparolaVeche
            // 
            this.tbparolaVeche.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.tbparolaVeche.Name = "tbparolaVeche";
            this.tbparolaVeche.Size = new System.Drawing.Size(200, 25);
            this.tbparolaVeche.Text = "Parola veche";
            this.tbparolaVeche.Click += new System.EventHandler(this.tbparolaVeche_Click);
            this.tbparolaVeche.MouseLeave += new System.EventHandler(this.tbparolaVeche_MouseLeave);
            // 
            // tbparolaNoua
            // 
            this.tbparolaNoua.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.tbparolaNoua.Name = "tbparolaNoua";
            this.tbparolaNoua.Size = new System.Drawing.Size(200, 25);
            this.tbparolaNoua.Text = "Parola noua";
            this.tbparolaNoua.Click += new System.EventHandler(this.tbparolaNoua_Click);
            this.tbparolaNoua.MouseLeave += new System.EventHandler(this.tbparolaNoua_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // Deconectare
            // 
            this.Deconectare.MergeIndex = 0;
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(235, 26);
            this.Deconectare.Text = "Deconectare";
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // stergereContToolStripMenuItem
            // 
            this.stergereContToolStripMenuItem.Name = "stergereContToolStripMenuItem";
            this.stergereContToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.stergereContToolStripMenuItem.Text = "Sterge contul";
            this.stergereContToolStripMenuItem.Click += new System.EventHandler(this.stergereContToolStripMenuItem_Click);
            // 
            // pbStudent
            // 
            this.pbStudent.Location = new System.Drawing.Point(800, 30);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(61, 47);
            this.pbStudent.TabIndex = 21;
            this.pbStudent.TabStop = false;
            // 
            // pbicon
            // 
            this.pbicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.pbicon.BackgroundImage = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Image = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Location = new System.Drawing.Point(0, 1);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(118, 67);
            this.pbicon.TabIndex = 1;
            this.pbicon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1126, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1123, 598);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.meniuForm1);
            this.Controls.Add(this.bCautare);
            this.Controls.Add(this.tbCautare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bInregistrare);
            this.Controls.Add(this.bLogare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbicon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHope";
            this.Load += new System.EventHandler(this.Logare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.meniuForm1.ResumeLayout(false);
            this.meniuForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbicon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbDepartament;
        private System.Windows.Forms.ToolStripComboBox cbProgramStudii;
        private System.Windows.Forms.ToolStripComboBox cbOras;
        public System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.TextBox tbCautare;
        private System.Windows.Forms.Button bCautare;
        public System.Windows.Forms.MenuStrip meniuForm1;
        private System.Windows.Forms.ToolStripMenuItem joburileMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem modificăParolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbparolaVeche;
        private System.Windows.Forms.ToolStripTextBox tbparolaNoua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Deconectare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        public System.Windows.Forms.Button bLogare;
        public System.Windows.Forms.Button bInregistrare;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbStudent;
        public static System.Windows.Forms.ToolStripMenuItem ContulMeu;
    }
}
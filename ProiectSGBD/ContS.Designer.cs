
namespace ProiectSGBD
{
    partial class ContS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContS));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contulMeu = new System.Windows.Forms.ToolStripMenuItem();
            this.joburiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.modificăParolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbparolaVeche = new System.Windows.Forms.ToolStripTextBox();
            this.tbparolaNoua = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Deconectare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRemove = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbicon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contulMeu});
            this.menuStrip1.Location = new System.Drawing.Point(907, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(139, 38);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contulMeu
            // 
            this.contulMeu.BackColor = System.Drawing.Color.White;
            this.contulMeu.Checked = true;
            this.contulMeu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contulMeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joburiToolStripMenuItem,
            this.toolStripSeparator3,
            this.modificăParolaToolStripMenuItem,
            this.toolStripSeparator1,
            this.Deconectare,
            this.toolStripSeparator2,
            this.stergereContToolStripMenuItem});
            this.contulMeu.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.contulMeu.MergeIndex = 0;
            this.contulMeu.Name = "contulMeu";
            this.contulMeu.Padding = new System.Windows.Forms.Padding(5);
            this.contulMeu.Size = new System.Drawing.Size(129, 34);
            this.contulMeu.Text = "Contul meu";
            // 
            // joburiToolStripMenuItem
            // 
            this.joburiToolStripMenuItem.Name = "joburiToolStripMenuItem";
            this.joburiToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.joburiToolStripMenuItem.Text = "Joburi";
            this.joburiToolStripMenuItem.Click += new System.EventHandler(this.joburiToolStripMenuItem_Click);
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
            this.tbparolaVeche.Text = "Parola curentă";
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
            // bRemove
            // 
            this.bRemove.BackColor = System.Drawing.Color.White;
            this.bRemove.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bRemove.Location = new System.Drawing.Point(454, 503);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(191, 69);
            this.bRemove.TabIndex = 25;
            this.bRemove.Text = "Șterge job";
            this.bRemove.UseVisualStyleBackColor = false;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(178, 172);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(753, 325);
            this.dataGridView3.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 41);
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(440, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aplicările mele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "StudentHope";
            // 
            // pbicon
            // 
            this.pbicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.pbicon.BackgroundImage = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Image = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Location = new System.Drawing.Point(0, 10);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(118, 67);
            this.pbicon.TabIndex = 21;
            this.pbicon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1126, 103);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pbStudent
            // 
            this.pbStudent.Location = new System.Drawing.Point(843, 39);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(61, 47);
            this.pbStudent.TabIndex = 30;
            this.pbStudent.TabStop = false;
            // 
            // ContS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1123, 598);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbicon);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContS_FormClosed);
            this.Load += new System.EventHandler(this.ContS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificăParolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbparolaVeche;
        private System.Windows.Forms.ToolStripTextBox tbparolaNoua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Deconectare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        private System.Windows.Forms.Button bRemove;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbicon;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.ToolStripMenuItem joburiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem contulMeu;
    }
}
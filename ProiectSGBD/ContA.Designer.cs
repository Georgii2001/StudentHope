
namespace ProiectSGBD
{
    partial class ContA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bRemove = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bModifica = new System.Windows.Forms.Button();
            this.bAplicari = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contulMeu = new System.Windows.Forms.ToolStripMenuItem();
            this.modificăParolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbparolaVeche = new System.Windows.Forms.ToolStripTextBox();
            this.tbparolaNoua = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Deconectare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbicon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bExport = new System.Windows.Forms.Button();
            this.bSalvare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 41);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(440, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Joburi adăugate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "StudentHope";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 161);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1043, 325);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // bRemove
            // 
            this.bRemove.BackColor = System.Drawing.Color.White;
            this.bRemove.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bRemove.Location = new System.Drawing.Point(194, 508);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(153, 69);
            this.bRemove.TabIndex = 15;
            this.bRemove.Text = "Șterge job";
            this.bRemove.UseVisualStyleBackColor = false;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.White;
            this.bAdd.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bAdd.Location = new System.Drawing.Point(23, 508);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(155, 69);
            this.bAdd.TabIndex = 16;
            this.bAdd.Text = "Adaugă job";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bModifica
            // 
            this.bModifica.BackColor = System.Drawing.Color.White;
            this.bModifica.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bModifica.Location = new System.Drawing.Point(367, 508);
            this.bModifica.Name = "bModifica";
            this.bModifica.Size = new System.Drawing.Size(156, 69);
            this.bModifica.TabIndex = 17;
            this.bModifica.Text = "Modifică job";
            this.bModifica.UseVisualStyleBackColor = false;
            this.bModifica.Click += new System.EventHandler(this.bModifica_Click);
            // 
            // bAplicari
            // 
            this.bAplicari.BackColor = System.Drawing.Color.White;
            this.bAplicari.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bAplicari.Location = new System.Drawing.Point(730, 508);
            this.bAplicari.Name = "bAplicari";
            this.bAplicari.Size = new System.Drawing.Size(170, 69);
            this.bAplicari.TabIndex = 18;
            this.bAplicari.Text = "Vizualizează aplicări";
            this.bAplicari.UseVisualStyleBackColor = false;
            this.bAplicari.Click += new System.EventHandler(this.bAplicari_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contulMeu});
            this.menuStrip1.Location = new System.Drawing.Point(934, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(137, 38);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contulMeu
            // 
            this.contulMeu.BackColor = System.Drawing.Color.White;
            this.contulMeu.Checked = true;
            this.contulMeu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contulMeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            // pbicon
            // 
            this.pbicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.pbicon.BackgroundImage = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Image = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Location = new System.Drawing.Point(0, -1);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(118, 67);
            this.pbicon.TabIndex = 10;
            this.pbicon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1126, 103);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bExport
            // 
            this.bExport.BackColor = System.Drawing.Color.White;
            this.bExport.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bExport.Location = new System.Drawing.Point(920, 508);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(170, 69);
            this.bExport.TabIndex = 20;
            this.bExport.Text = "Export XML";
            this.bExport.UseVisualStyleBackColor = false;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bSalvare
            // 
            this.bSalvare.BackColor = System.Drawing.Color.White;
            this.bSalvare.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bSalvare.Location = new System.Drawing.Point(547, 508);
            this.bSalvare.Name = "bSalvare";
            this.bSalvare.Size = new System.Drawing.Size(162, 69);
            this.bSalvare.TabIndex = 21;
            this.bSalvare.Text = "Salvare";
            this.bSalvare.UseVisualStyleBackColor = false;
            this.bSalvare.Click += new System.EventHandler(this.bSalvare_Click);
            // 
            // ContA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1123, 598);
            this.Controls.Add(this.bSalvare);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.bAplicari);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bModifica);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbicon);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContA";
            this.Load += new System.EventHandler(this.ContA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbicon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bModifica;
        private System.Windows.Forms.Button bAplicari;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Deconectare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem modificăParolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbparolaVeche;
        public System.Windows.Forms.ToolStripMenuItem contulMeu;
        private System.Windows.Forms.ToolStripTextBox tbparolaNoua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bSalvare;
    }
}
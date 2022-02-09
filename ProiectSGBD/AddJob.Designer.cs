
namespace ProiectSGBD
{
    partial class AddJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJob));
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbDescriere = new System.Windows.Forms.RichTextBox();
            this.cbOras = new System.Windows.Forms.ComboBox();
            this.cbProgramStudii = new System.Windows.Forms.ComboBox();
            this.cbDepartament = new System.Windows.Forms.ComboBox();
            this.tbFirma = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.Firma = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbicon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "StudentHope";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.White;
            this.bAdd.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.bAdd.Location = new System.Drawing.Point(212, 431);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(154, 45);
            this.bAdd.TabIndex = 23;
            this.bAdd.Text = "Adaugă";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(217, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adaugă job:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10F);
            this.label7.Location = new System.Drawing.Point(114, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Descriere job";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.rtbDescriere);
            this.panel1.Controls.Add(this.cbOras);
            this.panel1.Controls.Add(this.cbProgramStudii);
            this.panel1.Controls.Add(this.cbDepartament);
            this.panel1.Controls.Add(this.tbFirma);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.Firma);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Location = new System.Drawing.Point(264, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 532);
            this.panel1.TabIndex = 27;
            // 
            // rtbDescriere
            // 
            this.rtbDescriere.Location = new System.Drawing.Point(238, 348);
            this.rtbDescriere.Name = "rtbDescriere";
            this.rtbDescriere.Size = new System.Drawing.Size(226, 20);
            this.rtbDescriere.TabIndex = 49;
            this.rtbDescriere.Text = "";
            // 
            // cbOras
            // 
            this.cbOras.FormattingEnabled = true;
            this.cbOras.Location = new System.Drawing.Point(183, 277);
            this.cbOras.Name = "cbOras";
            this.cbOras.Size = new System.Drawing.Size(281, 24);
            this.cbOras.TabIndex = 47;
            // 
            // cbProgramStudii
            // 
            this.cbProgramStudii.FormattingEnabled = true;
            this.cbProgramStudii.Location = new System.Drawing.Point(275, 241);
            this.cbProgramStudii.Name = "cbProgramStudii";
            this.cbProgramStudii.Size = new System.Drawing.Size(189, 24);
            this.cbProgramStudii.TabIndex = 46;
            // 
            // cbDepartament
            // 
            this.cbDepartament.FormattingEnabled = true;
            this.cbDepartament.Location = new System.Drawing.Point(235, 208);
            this.cbDepartament.Name = "cbDepartament";
            this.cbDepartament.Size = new System.Drawing.Size(229, 24);
            this.cbDepartament.TabIndex = 45;
            // 
            // tbFirma
            // 
            this.tbFirma.Enabled = false;
            this.tbFirma.Location = new System.Drawing.Point(183, 173);
            this.tbFirma.Name = "tbFirma";
            this.tbFirma.Size = new System.Drawing.Size(281, 22);
            this.tbFirma.TabIndex = 44;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(183, 140);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(281, 22);
            this.tbId.TabIndex = 43;
            // 
            // Firma
            // 
            this.Firma.AutoSize = true;
            this.Firma.Font = new System.Drawing.Font("Georgia", 10F);
            this.Firma.Location = new System.Drawing.Point(114, 173);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(63, 20);
            this.Firma.TabIndex = 42;
            this.Firma.Text = "Firma*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10F);
            this.label10.Location = new System.Drawing.Point(114, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Id*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F);
            this.label3.Location = new System.Drawing.Point(114, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Program de studiu*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F);
            this.label4.Location = new System.Drawing.Point(114, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Departament*";
            // 
            // tbPost
            // 
            this.tbPost.Location = new System.Drawing.Point(183, 310);
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(281, 22);
            this.tbPost.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F);
            this.label5.Location = new System.Drawing.Point(114, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Post*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10F);
            this.label6.Location = new System.Drawing.Point(114, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Oraș*";
            // 
            // pbicon
            // 
            this.pbicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.pbicon.BackgroundImage = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Image = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Location = new System.Drawing.Point(-1, 0);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(118, 67);
            this.pbicon.TabIndex = 25;
            this.pbicon.TabStop = false;
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1123, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbicon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddJob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddJob_FormClosing);
            this.Load += new System.EventHandler(this.AddJob_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbicon;
        public  System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        public  System.Windows.Forms.ComboBox cbOras;
        public System.Windows.Forms.ComboBox cbProgramStudii;
        public System.Windows.Forms.ComboBox cbDepartament;
        public System.Windows.Forms.TextBox tbFirma;
        public System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label Firma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox rtbDescriere;
    }
}
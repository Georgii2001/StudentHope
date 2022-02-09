
namespace ProiectSGBD
{
    partial class Inregistrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inregistrare));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pbicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "StudentHope";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(217, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 235);
            this.button1.TabIndex = 13;
            this.button1.Text = "Angajator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(396, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Înregistrează-te ca:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(216)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(645, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 235);
            this.button2.TabIndex = 15;
            this.button2.Text = "Student";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbicon
            // 
            this.pbicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.pbicon.BackgroundImage = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Image = global::ProiectSGBD.Properties.Resources._7211547;
            this.pbicon.Location = new System.Drawing.Point(1, -3);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(118, 67);
            this.pbicon.TabIndex = 10;
            this.pbicon.TabStop = false;
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1123, 598);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbicon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inregistrare_FormClosed);
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbicon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
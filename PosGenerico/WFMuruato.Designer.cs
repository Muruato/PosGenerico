namespace PosGenerico
{
    partial class WFMuruato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WFMuruato));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSM = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.picGuts = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radButBehe = new System.Windows.Forms.RadioButton();
            this.radButGuts = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picGuts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uriel Muruato Martinez";
            // 
            // btnSM
            // 
            this.btnSM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSM.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSM.Location = new System.Drawing.Point(12, 266);
            this.btnSM.Name = "btnSM";
            this.btnSM.Size = new System.Drawing.Size(109, 46);
            this.btnSM.TabIndex = 1;
            this.btnSM.Text = "Saludar con Mensaje";
            this.btnSM.UseVisualStyleBackColor = true;
            this.btnSM.Click += new System.EventHandler(this.btnSM_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExit.Location = new System.Drawing.Point(599, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Regresar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSF
            // 
            this.btnSF.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSF.Location = new System.Drawing.Point(144, 266);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(113, 46);
            this.btnSF.TabIndex = 3;
            this.btnSF.Text = "Saludar desde Form";
            this.btnSF.UseVisualStyleBackColor = true;
            this.btnSF.Click += new System.EventHandler(this.btnSF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del integrante de la banda del halcon";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Algerian", 8.25F);
            this.txtNom.Location = new System.Drawing.Point(80, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(142, 22);
            this.txtNom.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNom.Location = new System.Drawing.Point(13, 88);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(69, 15);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Usted Es: ";
            // 
            // picGuts
            // 
            this.picGuts.Image = ((System.Drawing.Image)(resources.GetObject("picGuts.Image")));
            this.picGuts.Location = new System.Drawing.Point(12, 9);
            this.picGuts.Name = "picGuts";
            this.picGuts.Size = new System.Drawing.Size(191, 155);
            this.picGuts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuts.TabIndex = 8;
            this.picGuts.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "OST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.radButBehe);
            this.panel1.Controls.Add(this.radButGuts);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(222, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 155);
            this.panel1.TabIndex = 0;
            // 
            // radButBehe
            // 
            this.radButBehe.AutoSize = true;
            this.radButBehe.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radButBehe.Location = new System.Drawing.Point(95, 15);
            this.radButBehe.Name = "radButBehe";
            this.radButBehe.Size = new System.Drawing.Size(66, 19);
            this.radButBehe.TabIndex = 14;
            this.radButBehe.TabStop = true;
            this.radButBehe.Text = "Behelit";
            this.radButBehe.UseVisualStyleBackColor = true;
            // 
            // radButGuts
            // 
            this.radButGuts.AutoSize = true;
            this.radButGuts.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radButGuts.Location = new System.Drawing.Point(3, 15);
            this.radButGuts.Name = "radButGuts";
            this.radButGuts.Size = new System.Drawing.Size(52, 19);
            this.radButGuts.TabIndex = 9;
            this.radButGuts.TabStop = true;
            this.radButGuts.Text = "Guts";
            this.radButGuts.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(112, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "stop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "play";
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(115, 106);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 46);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 11;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(4, 106);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(46, 46);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 9;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Location = new System.Drawing.Point(402, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 106);
            this.panel2.TabIndex = 9;
            // 
            // WFMuruato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(720, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picGuts);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSM);
            this.Controls.Add(this.label1);
            this.Name = "WFMuruato";
            this.Text = "WFMuruato";
            this.Load += new System.EventHandler(this.WFMuruato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGuts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSM;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox picGuts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radButBehe;
        private System.Windows.Forms.RadioButton radButGuts;
        private System.Windows.Forms.Panel panel2;
    }
}
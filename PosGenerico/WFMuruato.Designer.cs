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
            this.btnMusica = new System.Windows.Forms.Button();
            this.picGuts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGuts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uriel Muruato Martinez";
            // 
            // btnSM
            // 
            this.btnSM.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSM.Location = new System.Drawing.Point(12, 223);
            this.btnSM.Name = "btnSM";
            this.btnSM.Size = new System.Drawing.Size(109, 51);
            this.btnSM.TabIndex = 1;
            this.btnSM.Text = "Saludar con Mensaje";
            this.btnSM.UseVisualStyleBackColor = true;
            this.btnSM.Click += new System.EventHandler(this.btnSM_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Algerian", 8.25F);
            this.btnExit.Location = new System.Drawing.Point(436, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Regresar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSF
            // 
            this.btnSF.Font = new System.Drawing.Font("Algerian", 8.25F);
            this.btnSF.Location = new System.Drawing.Point(144, 223);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(109, 51);
            this.btnSF.TabIndex = 3;
            this.btnSF.Text = "Saludar desde Form";
            this.btnSF.UseVisualStyleBackColor = true;
            this.btnSF.Click += new System.EventHandler(this.btnSF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 8.25F);
            this.label2.Location = new System.Drawing.Point(266, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del integrante de la banda del halcon";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Algerian", 8.25F);
            this.txtNom.Location = new System.Drawing.Point(333, 67);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(142, 22);
            this.txtNom.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Algerian", 8.25F);
            this.lblNom.Location = new System.Drawing.Point(331, 149);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(60, 12);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Usted Es: ";
            // 
            // btnMusica
            // 
            this.btnMusica.Font = new System.Drawing.Font("Algerian", 8.25F);
            this.btnMusica.Location = new System.Drawing.Point(301, 223);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(109, 51);
            this.btnMusica.TabIndex = 7;
            this.btnMusica.Text = "Reproducir Guts Theme";
            this.btnMusica.UseVisualStyleBackColor = true;
            this.btnMusica.Click += new System.EventHandler(this.btnMusica_Click);
            // 
            // picGuts
            // 
            this.picGuts.Image = ((System.Drawing.Image)(resources.GetObject("picGuts.Image")));
            this.picGuts.Location = new System.Drawing.Point(12, 67);
            this.picGuts.Name = "picGuts";
            this.picGuts.Size = new System.Drawing.Size(100, 87);
            this.picGuts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuts.TabIndex = 8;
            this.picGuts.TabStop = false;
            this.picGuts.Click += new System.EventHandler(this.picGuts_Click);
            // 
            // WFMuruato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 324);
            this.Controls.Add(this.picGuts);
            this.Controls.Add(this.btnMusica);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSM);
            this.Controls.Add(this.label1);
            this.Name = "WFMuruato";
            this.Text = "WFMuruato";
            ((System.ComponentModel.ISupportInitialize)(this.picGuts)).EndInit();
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
        private System.Windows.Forms.Button btnMusica;
        private System.Windows.Forms.PictureBox picGuts;
    }
}
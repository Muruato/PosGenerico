namespace PosGenerico
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
            this.btnMuru = new System.Windows.Forms.Button();
            this.btnJes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMuru
            // 
            this.btnMuru.Location = new System.Drawing.Point(35, 128);
            this.btnMuru.Name = "btnMuru";
            this.btnMuru.Size = new System.Drawing.Size(75, 23);
            this.btnMuru.TabIndex = 0;
            this.btnMuru.Text = "Muruato";
            this.btnMuru.UseVisualStyleBackColor = true;
            this.btnMuru.Click += new System.EventHandler(this.btnMuru_Click);
            // 
            // btnJes
            // 
            this.btnJes.Location = new System.Drawing.Point(273, 128);
            this.btnJes.Name = "btnJes";
            this.btnJes.Size = new System.Drawing.Size(75, 23);
            this.btnJes.TabIndex = 1;
            this.btnJes.Text = "Jesus";
            this.btnJes.UseVisualStyleBackColor = true;
            this.btnJes.Click += new System.EventHandler(this.btnJes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.btnJes);
            this.Controls.Add(this.btnMuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuru;
        private System.Windows.Forms.Button btnJes;
    }
}


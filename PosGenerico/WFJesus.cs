using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosGenerico
{
    public partial class WFJesus : Form
    {
        public WFJesus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Ella no te ama, lo siento";
            string caption = "La verdad absoluta de la vida";

            // Displays the MessageBox.
            DialogResult result;
            result = MessageBox.Show(message, caption,MessageBoxButtons.OK);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblNombre.Text = "Si tu nombre es " + textBox1.Text + " eres gay!";
        }
    }
}

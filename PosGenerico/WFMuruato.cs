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
    public partial class WFMuruato : Form
    {
        String nombre;

        public WFMuruato()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSF_Click(object sender, EventArgs e)
        {
            nombre = txtNom.Text;
        }

        private void btnSM_Click(object sender, EventArgs e)
        {
            nombre = txtNom.Text;

            MessageBox.Show("Usted Es: "+nombre);
        }
    }
}

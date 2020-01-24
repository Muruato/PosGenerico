using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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

            lblNom.Text = "Usted Es: " + nombre;

            txtNom.Text = "";

        }

        private void btnSM_Click(object sender, EventArgs e)
        {
            nombre = txtNom.Text;

            MessageBox.Show("Usted Es: "+nombre);
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();

            player.SoundLocation = "guts.wav";
            player.Play();
        }
    }
}

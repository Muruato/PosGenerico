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
        SoundPlayer player = new SoundPlayer();
        SoundPlayer player2 = new SoundPlayer();

        public WFMuruato()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            player.Stop();
            player2.Stop();
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

            MessageBox.Show(nombre+" Miembro de la banda del halcon");
        }

        
    
        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            if (radButGuts.Checked == true)
            {
                player2.Stop();
                String cancionGuts= "guts.wav";
            player.SoundLocation = cancionGuts;
            player.Play();
            }
            
            else if (radButBehe.Checked == true)
            {
                player.Stop();
                String cancionBehe = "behelit.wav";
                player2.SoundLocation = cancionBehe;
                player2.Play();    
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
           player.Stop();
           player2.Stop();
        }

        private void WFMuruato_Load(object sender, EventArgs e)
        {

        }
    }
}

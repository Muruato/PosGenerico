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
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnJes_Click(object sender, EventArgs e)
        {
            WFJesus jesu = new WFJesus();
            jesu.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String ost = "sable.wav";
            player.SoundLocation = ost;
            player.Play();

            WFMuruato muru = new WFMuruato();
            muru.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMuru_Click(object sender, EventArgs e)
        {
            WFMuruato muru = new WFMuruato();
            muru.ShowDialog();
        }

        private void btnJes_Click(object sender, EventArgs e)
        {
            WFJesus jesu = new WFJesus();
            jesu.ShowDialog();
        }
    }
}

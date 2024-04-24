using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();
            firma.ShowDialog();
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Juego juego = new Juego();
            juego.ShowDialog();
        }
    }
}

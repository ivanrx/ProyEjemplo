using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyEjemplo
{
    internal class ClsDisparo
    {
        public PictureBox disparo;

        public void crearDisparo(System.Drawing.Point posicion)
        {
            disparo = new PictureBox();
            disparo.Width = 10;
            disparo.Height = 10;
            disparo.BackColor = System.Drawing.Color.Yellow;
            disparo.Location = posicion;
        }
    }
}

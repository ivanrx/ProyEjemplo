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
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }

        ClsNaves objNaveJugador = new ClsNaves();
        ClsNaves objNaveEnemigo = new ClsNaves();


        private void Juego_Load(object sender, EventArgs e)
        {
            objNaveJugador.CrearJugador();
            Controls.Add(objNaveJugador.imgNave);

        }
        int auxiliarX = 0;
        int contador = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador<5)
            {
                objNaveEnemigo.CrearEnemigo();
                objNaveEnemigo.imgNave.Location = new Point(auxiliarX += 50, objNaveEnemigo.imgNave.Location.Y);
                Controls.Add(objNaveEnemigo.imgNave);

                contador++;
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}

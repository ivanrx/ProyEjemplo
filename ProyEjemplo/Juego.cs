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

        List<ClsNaves> ListaNaves = new List<ClsNaves>();
        

        int puntaje = 0;

        private void Juego_Load(object sender, EventArgs e)
        {
            objNaveJugador.CrearJugador();
            Controls.Add(objNaveJugador.imgNave);

        }
        int auxiliarX = 0;
        int contador = 0;

        //Crear enemigos
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador<15)
            {
                objNaveEnemigo.CrearEnemigo();
                objNaveEnemigo.imgNave.Location = new Point(auxiliarX += 50, objNaveEnemigo.imgNave.Location.Y);
                Controls.Add(objNaveEnemigo.imgNave);
                ListaNaves.Add(objNaveEnemigo);
                objNaveEnemigo.imgNave.Tag = "Enemigo";

                contador++;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        //Movimientos
        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) 
            {
                objNaveJugador.imgNave.Location = new Point(
                    objNaveJugador.imgNave.Location.X - 10,
                    objNaveJugador.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(
                    objNaveJugador.imgNave.Location.X + 10,
                    objNaveJugador.imgNave.Location.Y);
            }

            if(e.KeyCode == Keys.Space)
            {
                Disparar();
            }
        }

        private void Disparar()
        {
            PictureBox disparo = new PictureBox();
            disparo.Width = 10;
            disparo.Height = 10;
            disparo.BackColor = System.Drawing.Color.Yellow;
            disparo.Tag = "Disparo";
            disparo.Left = objNaveJugador.imgNave.Left + 45;
            disparo.Top = objNaveJugador.imgNave.Top - 10;
            this.Controls.Add(disparo);
        }

        private void MovimientoDisparo()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "Disparo")
                {
                    x.Top -= 10;
                    if(x.Top < 0)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void Colision()
        {
            foreach(Control d in this.Controls)
            {
                foreach(Control e in this.Controls)
                {
                    if(d is PictureBox && d.Tag == "Disparo")
                    {
                        if(e is PictureBox && e.Tag == "Enemigo")
                        {
                            if(d.Bounds.IntersectsWith(e.Bounds))
                            {
                                this.Controls.Remove(e);
                                this.Controls.Remove(d);
                                puntaje++;
                                lblPuntaje.Text = "Puntaje: " + puntaje;
                                if(puntaje > 14)
                                {
                                    objNaveEnemigo.CrearBoss();

                                }
                            }
                        }
                    }
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            MovimientoDisparo();
            Colision();
        }
    }
}

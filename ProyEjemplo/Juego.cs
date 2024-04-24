﻿using System;
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
            if (contador<15)
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
        }
    }
}
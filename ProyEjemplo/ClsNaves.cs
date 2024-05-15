using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyEjemplo
{
    internal class ClsNaves
    {
        //constructor
        public ClsNaves()
        {
            vida = 0;
            nombre = "";
            daño = 0;
        }

        //propiedades
        public int vida;
        string nombre;
        int daño;
        public PictureBox imgNave;
        int posX;
        int posY;
        

        //metodos - acciones
        public void CrearJugador()
        {
            vida = 100;
            nombre = "jugador";
            daño = 1;

            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.Location = new System.Drawing.Point(350, 300);
            imgNave.Image = Properties.Resources.nave;
        }

        //Crear enemigos en posiciones aleatorias
        Random aleatorioEnemigo = new Random();
        Random aleatorioPosY = new Random();
        int codigoEnemigo;

        public void CrearEnemigo()
        {
            codigoEnemigo = aleatorioEnemigo.Next(0, 2);

            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.Size = new System.Drawing.Size(50, 50);

            posY = aleatorioPosY.Next(0,200);

            switch (codigoEnemigo)
            {
                case 0:
                    vida = 100;
                    nombre = "enemigo1";
                    daño = 1;
                    imgNave.Image = Properties.Resources.enemigo1;
                    break;
                case 1:
                    vida = 100;
                    nombre = "enemigo2";
                    daño = 1;
                    imgNave.Image = Properties.Resources.enemigo2;
                    break;
            }
            imgNave.Location = new System.Drawing.Point(0, posY);
        }

        public void CrearBoss()
        {
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.Size = new System.Drawing.Size(100, 100);
            imgNave.Image = Properties.Resources.enemigo1;
            imgNave.Location = new System.Drawing.Point(400, 100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

namespace ProyEjemplo
{
    public partial class Firma : Form
    {
        private Point punto = Point.Empty;
        private List<Point> listaPuntos = new List<Point>();
        private Pen lapiz = new Pen(Color.Black);
        private bool dibujo = false;
        Bitmap bmpFirma;
        public Firma()
        {
            InitializeComponent();
            bmpFirma = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujo = true;
                punto = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dibujo = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dibujo)
            {
                using (Graphics firma = pictureBox1.CreateGraphics())
                {
                    Pen lapiz = new Pen(Color.Black);
                    firma.DrawLine(lapiz, punto, e.Location);
                    punto = e.Location;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(bmpFirma != null)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Title = "Guardar firma como";
                    saveFileDialog1.FileName = "firma.jpg";

                    if(saveFileDialog1.ShowDialog() == DialogResult.OK) bmpFirma.Save(saveFileDialog1.FileName);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

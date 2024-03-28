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
    public partial class FormFirma : Form
    {
        public FormFirma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lápiz = new Pen(Color.Black);
            papel.DrawRectangle(lápiz, 10, 10, 100, 50);
            papel.DrawRectangle(lápiz, 10, 75, 100, 100);
        }

        private void FormFirma_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}

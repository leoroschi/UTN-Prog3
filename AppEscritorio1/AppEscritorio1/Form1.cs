using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio1
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a Aplicación 1");
        }

        private void Ventana1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Cerrando formulario");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted acaba de cambiar de color al botón");
            btn1.BackgroundImage = null;
            btn1.BackColor = Color.AntiqueWhite;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }
    }
}

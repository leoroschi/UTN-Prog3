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
    }
}

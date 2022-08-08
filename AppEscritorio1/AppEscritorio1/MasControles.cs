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
    public partial class MasControles : Form
    {
        public MasControles()
        {
            InitializeComponent();
        }
        private void MasControles_Load(object sender, EventArgs e)
        {
            //Deshabilito el Boton Ok.
            btnOk.Enabled = false;
        }
        private void ValidarOk()
        {
            //Habilita el Boton, siempre y cuando txtNombre tenga datos.
            btnOk.Enabled = (txtNombre.BackColor != Color.Red);
        }
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;
            ValidarOk();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //No valido datos ya que si el Boton esta Habilitado
            //es porque paso el Evento Validating del Nombre.
            String salida; //Declaro una variable para armar la salida.
            salida = "Nombe: " + txtNombre.Text + "\r\n";
            salida += "Ocupacion: " + (string)(cboxProgramador.Checked ?
            "Programador" : "No es Programador") + "\r\n";
            salida += "Sexo: " + (string)(rbtnHombre.Checked ? "Hombre" :
            "Mujer") + "\r\n";

            //Vuelco la salida al TextBox Salida.
            txtSalida.Text = salida;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// (cbxProgramer.Checked ? "Programador" : "No es Programador") 
        /// Si cbxProgramer.Checked == true "Programador" si == false "No es programador"
    }
}

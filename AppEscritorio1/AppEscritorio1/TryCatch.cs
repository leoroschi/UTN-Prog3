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
    public partial class TryCatch : Form
    {
        public TryCatch()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumero.Text);
            }
            //Los identificadores de objetos que se utilizan
            //como fe son arbitrarios y solo existen en el ambito
            //del bloque Catch.
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}

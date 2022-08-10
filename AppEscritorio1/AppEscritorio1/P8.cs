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
    public partial class P8 : Form
    {
        public P8()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //NO ME ESTARIA ANDANDO EL frmListBoxCheckedListBox()

        //public frmListBoxCheckedListBox()
        //{
        //    InitializeComponent();
        //    //Con el metodo Add agregamos un ultimo Item a la
        //    //Colección de Items. Como parametro la cadena de caracteres.
        //    clbElementos.Items.Add("Diez");
        //}

        private void btnMover_Click(object sender, EventArgs e)
        {
            //Pregunta si la cantidad (Count) de elementos chequeados
            //en la coleccion de items chequeados(CheckedItems) es mayor a cero.
            if (clbElementos.CheckedItems.Count > 0)
            {
                //Si es mayor a cero. Limpia los Item en el ListBox.
                //La sentencia foreach recorre la coleccion de Items Seleccionados
                //Y los asigna de a uno a la variable item del tipo String.
                foreach (string item in clbElementos.CheckedItems)
                {
                    //Agrego los items seleccionados en la colección
                    //Al Listbox con el Metodo Add.
                    listBox1.Items.Add(item.ToString());
                }
                //Recorro todos los Items del CheckedListBox.
                for (int i = 0; i < clbElementos.Items.Count; i++)              
                    //Con el Metodo SetItemChecked, establesco en falso la
                    //casilla de verificación (No esta seleccionado).
                    //Como parametros i-El Indice y el valor de estado en este caso false.
                    clbElementos.SetItemChecked(i, false);

            }
        }
    }
}

﻿using System;
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

        private void lblPrimerEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            lblPrimerEtiqueta.BackColor = Color.Red;
            lblPrimerEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblPrimerEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblPrimerEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblPrimerEtiqueta.Cursor = Cursors.Arrow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBprueba.Text == "")
                tBprueba.BackColor = Color.Cyan;
            else
                tBprueba.BackColor = System.Drawing.SystemColors.Control;
        }

        private void tBprueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtTextBox2.Text.Length + " Caracteres");
        }
    }
}

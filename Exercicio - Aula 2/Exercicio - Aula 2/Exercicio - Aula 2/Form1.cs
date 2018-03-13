using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio___Aula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textoaeditar_Click(object sender, EventArgs e)
        {
            EditTexto edittexto = new EditTexto();

            edittexto.valedit = textoaeditar.Text;

            DialogResult resultado = edittexto.ShowDialog();



            if (resultado == DialogResult.OK) {

                string aux = edittexto.valedit;

                textoaeditar.Text = aux;

            }

        }
    }
}

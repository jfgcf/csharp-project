using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3__Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Falta Parametros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox1.SelectedIndex == 0)
            {
                int resultado = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int resultado = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int resultado = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int resultado = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);
            }
        }
    }
}

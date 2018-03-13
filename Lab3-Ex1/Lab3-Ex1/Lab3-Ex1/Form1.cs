using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox1.Text) && dateTimePicker1.Value.Date < DateTime.Now.Date && comboBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Campos Mal Preenchidos", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            MessageBox.Show("Foi Inserido o Seguinte Evento: " + Environment.NewLine + textBox2.Text + Environment.NewLine + dateTimePicker1.Value.ToString("dd/MM/yyyy") + Environment.NewLine + "com inicio às " + textBox1.Text + ":0" + Environment.NewLine + "e duração de " + comboBox1.SelectedItem.ToString()     , "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}       
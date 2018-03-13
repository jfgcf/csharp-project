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
    public partial class EditTexto : Form
    {
        
        public EditTexto()
        {
            InitializeComponent();


        }

        public string valedit {

            get { return textBox1.Text; }
            set { textBox1.Text=value; }
        }

        private void EditTexto_Load(object sender, EventArgs e)
        {

        }
    }
}

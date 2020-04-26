using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteAula17
{
    public partial class FormularioAula17 : Form
    {
        public FormularioAula17()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoExemplo2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(textBoxDividendo.Text);
            int divisor = Convert.ToInt32(textBoxDivisor.Text);
            double resto = dividendo % divisor;
            textBoxResto.Text = resto.ToString();

        }
    }
}

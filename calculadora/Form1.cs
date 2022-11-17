using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 + valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 - valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 * valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            if ((valor1 > 0) && (valor2 > 0)
             resultado = valor1 / valor2;
            else
            {
                resultado = 0;
            }
            lblResultado.Text = resultado.ToString();

        }
    }
}

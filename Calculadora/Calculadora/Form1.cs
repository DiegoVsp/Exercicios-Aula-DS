using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.N1 = Convert.ToDouble(txtN1.Text);
            calc.N2 = Convert.ToDouble(txtN2.Text);

            calc.Somar();

            lblResultado.Text = Convert.ToString(calc.Result);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.N1 = Convert.ToDouble(txtN1.Text);
            calc.N2 = Convert.ToDouble(txtN2.Text);

            calc.Subtrair();
            lblResultado.Text = Convert.ToString(calc.Result);

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.N1 = Convert.ToDouble(txtN1.Text);
            calc.N2 = Convert.ToDouble(txtN2.Text);

            calc.Multiplicar();
            lblResultado.Text = Convert.ToString(calc.Result);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.N1 = Convert.ToDouble(txtN1.Text);
            calc.N2 = Convert.ToDouble(txtN2.Text);

            calc.Dividir();
            lblResultado.Text = Convert.ToString(calc.Result);
        }
    }
}

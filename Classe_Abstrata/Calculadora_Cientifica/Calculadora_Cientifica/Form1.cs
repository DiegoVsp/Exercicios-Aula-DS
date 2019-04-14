using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Cientifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Cientifica s = new Cientifica();
            s.Numero1 = Convert.ToDouble(txtNumero1.Text);
            s.Numero2 = Convert.ToDouble(txtNumero2.Text);
            s.Resultado=s.Soma();
            txtTotal.Text = Convert.ToString(s.Resultado);
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Cientifica s = new Cientifica();
            s.Numero1 = Convert.ToDouble(txtNumero1.Text);
            s.Numero2 = Convert.ToDouble(txtNumero2.Text);
            s.Resultado = s.Subtracao();
            txtTotal.Text = Convert.ToString(s.Resultado);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Cientifica s = new Cientifica();
            s.Numero1 = Convert.ToDouble(txtNumero1.Text);
            s.Numero2 = Convert.ToDouble(txtNumero2.Text);
            s.Resultado = s.divisao();
            txtTotal.Text = Convert.ToString(s.Resultado);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Cientifica s = new Cientifica();
            s.Numero1 = Convert.ToDouble(txtNumero1.Text);
            s.Numero2 = Convert.ToDouble(txtNumero2.Text);
            s.Resultado = s.multiplicacao();
            txtTotal.Text = Convert.ToString(s.Resultado);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Cientifica s = new Cientifica();
            s.Numero1 = Convert.ToDouble(txtNumero1.Text);
            s.Numero2 = Convert.ToDouble(txtNumero2.Text);
            s.Resultado = s.raizQuadrada();
            txtNumero2.Clear();
            txtTotal.Text = Convert.ToString(s.Resultado);
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            Cientifica s = new Cientifica();
            s.Numero1 = Convert.ToDouble(txtNumero1.Text);
            s.Numero2 = Convert.ToDouble(txtNumero2.Text);
            s.Resultado = s.potencia();
            txtTotal.Text = Convert.ToString(s.Resultado);
        }
    }
}

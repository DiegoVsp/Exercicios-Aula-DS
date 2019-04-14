using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtComprimento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLargura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Retangulo r1 = new Retangulo();


            r1.Comprimento = Convert.ToDouble(txtComprimento.Text);
            r1.Largura = Convert.ToDouble(txtLargura.Text);
            r1.Altura = Convert.ToDouble(txtAltura.Text);
            r1.Calcular();

            txtVolume.Text = Convert.ToString(r1.Volume);
            MessageBox.Show("O volume do Retangulo é de: " + r1.Volume);
            txtAltura.Clear();
            txtComprimento.Clear();
            txtLargura.Clear();
            txtVolume.Clear();
            
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
           
            

            
        }
    
    }
}
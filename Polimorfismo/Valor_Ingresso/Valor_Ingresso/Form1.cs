using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Valor_Ingresso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVip_Click(object sender, EventArgs e)
        {
            IngressoVip vip = new IngressoVip();
           

            MessageBox.Show("O valor do Ingresso VIP sai por:\n"+vip.ImprimirValor().ToString("C"));
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            IngressoNormal normal = new IngressoNormal();
            MessageBox.Show("O preço do Ingresso Normal sai por:\n " + normal.ImprimirValor().ToString("C"));
        }

        private void btnCamarote_Click(object sender, EventArgs e)
        {
            CamaroteInferior camarote = new CamaroteInferior();
            camarote.ValorAdicional = 30.00;
            camarote.Lugar = 15;

            MessageBox.Show("O valor do Ingresso para Camarote Inferior com a localização na \n"+camarote.Lugar+" º cadeira sai por: "+ camarote.ImprimirValor().ToString("C"));
        }


    }
}

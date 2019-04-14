using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastrodeCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (btnLigar.Text == "Ligar") 
            {
                txtStatus.Text = "Carro Ligado";
                
            }
           

        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (btnDesligar.Text == "Desligar")
            {
                txtStatus.Text = "Carro Desligado";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Automovel a1 = new Automovel();

            a1.Placa = txtPlaca.Text;
            a1.Cor = txtCor.Text;
            a1.Fabricante = txtFabricante.Text;

            txtNuPortas.Text = Convert.ToString(a1.NumeroDePortas1);
            txtAno.Text = Convert.ToString(a1.Ano);

            string mostrarDados = +a1.NumeroDePortas1 + "\n" + a1.Ano + "\n" + a1.Cor + "\n" + a1.Fabricante + "\n" + a1.Placa;

            MessageBox.Show("Cadastrado com Sucesso\n"+mostrarDados);
            txtPlaca.Enabled = false;
            txtCor.Enabled = false;
            txtFabricante.Enabled = false;
            txtNuPortas.Enabled = false;
            txtAno.Enabled = false;
            button1.Enabled = false;
        }

        

       
        

       
    }

       
}

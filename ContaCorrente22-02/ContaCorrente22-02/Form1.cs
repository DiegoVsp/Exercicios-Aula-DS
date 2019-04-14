using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContaCorrente22_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            Cliente cli = new Cliente();

            cli.Nome = txtNome.Text;
            cli.Cpf = txtCpf.Text;
            cli.Rg = txtRg.Text;
            cli.Endereco = txtEndereco.Text;

            c.Numero = Convert.ToInt16(txtNumero.Text);
            c.Saldo = Convert.ToDouble(txtSaldo.Text);

            MessageBox.Show("Cliente Cadastrado com Sucesso \n" + cli.Nome + "\n" + cli.Cpf + "\n" + c.Saldo);
            txtSaldo.Enabled = false;
            txtNumero.Enabled = false;
            btnCadastrar.Enabled = false;

        }

        private void txtRg_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Saldo = Convert.ToDouble(txtSaldo.Text);

            double valor = Convert.ToDouble(txtValor.Text);
            c.Sacar(valor);

            MessageBox.Show("Valor Sacado com Sucesso!!!\n Saldo atual: " + c.Saldo);
            txtSaldo.Text = Convert.ToString(c.Saldo);
            txtValor.Clear();
        }

       

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Saldo = Convert.ToDouble(txtSaldo.Text);

            double valor = Convert.ToDouble(txtValor.Text);
            c.Deposita(valor);

            MessageBox.Show("Valor Depositado com Sucesso!!!\n Saldo atual: " + c.Saldo);
            txtSaldo.Text = Convert.ToString(c.Saldo);
            txtValor.Clear();

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void valor_Click(object sender, EventArgs e)
        {

        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {

            Conta c = new Conta();
            c.Saldo = Convert.ToDouble(txtSaldo.Text);
            

            MessageBox.Show("Seu Saldo é de: " + c.PegaSaldo());
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

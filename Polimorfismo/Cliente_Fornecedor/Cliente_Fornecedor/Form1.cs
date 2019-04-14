using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente_Fornecedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente fisica = new Cliente();
            fisica.nome = "Joana";
            fisica.endereco = "Rua Nove de Julho";
            fisica.telefone = "123456";
            fisica.CPF1 = "25945218847";
            MessageBox.Show("Atenção Cliente: " + fisica.nome + "\n" + fisica.VerificarDocumento());
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor juridico = new Fornecedor();
            juridico.nome = "Americanas.com";
            juridico.endereco = "Rua Nove de Julho";
            juridico.telefone = "123456";
            juridico.CNPJ1 = "25945218847";
            MessageBox.Show("Atenção Cliente: " + juridico.nome + "\n" + juridico.VerificarDocumento());
        }

    }
}

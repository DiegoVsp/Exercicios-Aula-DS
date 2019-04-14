using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmDiretor : Form
    {
        public frmDiretor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Diretor d1 = new Cadastro.Diretor();

            d1.Codigo = Convert.ToInt16(txtCod.Text);
            d1.CartTrab = Convert.ToString(txtCartTrab.Text);
            d1.Bonificacao = Convert.ToDouble(txtBonificacao.Text);
            d1.Salario = Convert.ToDouble(txtSalario.Text);

            d1.Nome = txtNome.Text;
            d1.Idade = Convert.ToInt16(txtIdade.Text);
            d1.Sexo = Convert.ToChar(txtSexo.Text);
            d1.Cpf = txtCpf.Text;
            d1.Rg = txtRg.Text;
            d1.Email = txtEmail.Text;
            d1.Endereco = txtEndereco.Text;
            d1.Cidade = txtCidade.Text;
            d1.Telefone = Convert.ToInt32(txtTelefone.Text);

            if (MessageBox.Show("Deseja Cadastrar esse Diretor?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(d1.Mostrar());
            }

           
        }

        private void frmDiretor_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }

        private void frmDiretor_Load(object sender, EventArgs e)
        {

        }

        private void frmDiretor_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

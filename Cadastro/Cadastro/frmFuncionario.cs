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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f1 = new Funcionario();

            f1.Codigo = Convert.ToInt16(txtCod.Text);
            f1.CartTrab = txtCartTrab.Text;
            f1.Cargo = txtCargo.Text;
            f1.AdiclNotur = Convert.ToDouble(txtAdcNoturno.Text);
            f1.Salario = Convert.ToDouble(txtSalario.Text);
            f1.Inss = Convert.ToDouble(txtInss.Text);

            f1.Nome = txtNome.Text;
            f1.Idade = Convert.ToInt16(txtIdade.Text);
            f1.Sexo = Convert.ToChar(txtSexo.Text);
            f1.Cpf = txtCpf.Text;
            f1.Rg = txtRg.Text;
            f1.Email = txtEmail.Text;
            f1.Endereco = txtEndereco.Text;
            f1.Cidade = txtCidade.Text;
            f1.Telefone = Convert.ToInt32(txtTelefone.Text);

           if (MessageBox.Show("Deseja cadastrar esse funcionário?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Salario do Funcionário"+f1.Mostrar().ToString("C") + "\n***-- Cadastrado com sucesso!--***");
            }
        }

        private void frmFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

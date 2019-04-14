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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Aluno a1 = new Aluno();
            a1.Rm = txtRm.Text;
            a1.Curso = txtcCurso.Text;
            a1.Modulo = txtModulo.Text;

            a1.Nome = txtNome.Text;
            a1.Idade = Convert.ToInt16(txtIdade.Text);
            a1.Sexo = Convert.ToChar(txtSexo.Text);
            a1.Cpf = txtCpf.Text;
            a1.Rg = txtRg.Text;
            a1.Email = txtEmail.Text;
            a1.Endereco = txtEndereco.Text;
            a1.Cidade = txtCidade.Text;
            a1.Telefone = Convert.ToInt32(txtTelefone.Text);



            if (MessageBox.Show("Deseja Cadastrar esse Aluno?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(a1.Mostrar());
            }
                        

        }

        private void frmAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
    }


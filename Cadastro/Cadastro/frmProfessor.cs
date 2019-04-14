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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
        }

        private void grDados_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Professor p1 = new Professor();


            p1.Codigo = Convert.ToInt16(txtCod.Text);
            p1.Graducao = Convert.ToString(txtGraduacao.Text);
            p1.CartTrabalho = Convert.ToString(txtCartTrab.Text);
            p1.Especialidade = Convert.ToString(txtEsp.Text);
            p1.HoraTrab = Convert.ToDouble(txtHorasTrab.Text);
            p1.VlHora = Convert.ToDouble(txtVlHora.Text);

            p1.Nome = txtNome.Text;
            p1.Idade = Convert.ToInt16(txtIdade.Text);
            p1.Sexo = Convert.ToChar(txtSexo.Text);
            p1.Cpf = txtCpf.Text;
            p1.Rg = txtRg.Text;
            p1.Email = txtEmail.Text;
            p1.Endereco = txtEndereco.Text;
            p1.Cidade = txtCidade.Text;
            p1.Telefone = Convert.ToInt32(txtTelefone.Text);

            if (MessageBox.Show("Deseja Cadastrar esse Professor?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(p1.Mostrar());
            }

        }

        private void frmProfessor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

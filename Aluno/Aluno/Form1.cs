using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarDados_Click(object sender, EventArgs e)
        {
            Aluno a1 = new Aluno();

            a1.Matricula = txtMatricula.Text;
            a1.Nome = txtNome.Text;


            a1.Nota1 = Convert.ToDouble(txtNota1.Text);
            a1.Nota2 = Convert.ToDouble(txtNota2.Text);

            MessageBox.Show("Dados do Aluno\n" + "Matricula: " + a1.Matricula + "\n" + "Nome:" + a1.Nome + "\n" + "Nota 1:" + a1.Nota1 + "\n" + "Nota 2: " + a1.Nota2);

             }

       private void btnMedia_Click(object sender, EventArgs e)
        {
            Aluno a1 = new Aluno();
            a1.Nota1 = Convert.ToDouble(txtNota1.Text);
            a1.Nota2 = Convert.ToDouble(txtNota2.Text);
            a1.TiraMedia();

            txtMedia.Text = Convert.ToString(a1.Media);
            if (a1.Media >= 6)
            {
                MessageBox.Show("Parabéns! Você foi Aprovado");
            }
            else {
                MessageBox.Show("Reprovado! HAHAHA...");
            }

        }

       private void txtMedia_TextChanged(object sender, EventArgs e)
       {

       }
        
        
    }
}

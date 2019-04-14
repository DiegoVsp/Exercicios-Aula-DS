using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCalc_Click(object sender, EventArgs e)
        {
             double tamanho;
            double gordura;

            tamanho = Convert.ToDouble(txtAltura.Text);
            gordura = Convert.ToDouble(txtPeso.Text);

            Pessoa pessoa = new Pessoa(tamanho, gordura);

            pessoa.Idade = Convert.ToInt16(txtIdade.Text);
            pessoa.Nome = Convert.ToString(txtNome.Text);
            pessoa.Sexo = "";

            if (rbMasculino.Checked) 
            {
                pessoa.Sexo = rbMasculino.Text;
            }
            if (rbFemino.Checked) 
            {
                pessoa.Sexo = rbFemino.Text;
            }

            
            double imcP = pessoa.CalcImc();
            
            /*imcP.ToString("F") -> Convert o imcP para 2 casas decimais*/

            if (imcP < 17)
            {
                MessageBox.Show("\nNome: "+pessoa.Nome+"\nIdade: "+pessoa.Idade+"\nSexo: " + pessoa.Sexo+"\nIMC de: " + imcP.ToString("F")+"\nVocê está muito abaixo do peso");
            }
            if ((imcP >= 17) && (imcP <= 18.49))
            {

                MessageBox.Show("\nNome: " + pessoa.Nome + "\nIdade: " + pessoa.Idade + "\nSexo: " + pessoa.Sexo + "\nIMC de: " + imcP.ToString("F") + "\nVocê está abaixo do peso");
            }
            if ((imcP >= 18.50) && (imcP <= 24.99))
            {
                MessageBox.Show("\nNome: " + pessoa.Nome + "\nIdade: " + pessoa.Idade + "\nSexo: " + pessoa.Sexo + "\nIMC de: " + imcP.ToString("F") + "\nVocê está no seu peso normal");

            }

            if ((imcP >= 25) && (imcP <= 29.99))
            {
                MessageBox.Show("\nNome: " + pessoa.Nome + "\nIdade: " + pessoa.Idade + "\nSexo: " + pessoa.Sexo + "\nIMC de: " + imcP.ToString("F") + "\nVocê está acima do peso");
            }

            if ((imcP >= 30) && (imcP <= 34.99))
            {
                MessageBox.Show("\nNome: " + pessoa.Nome + "\nIdade: " + pessoa.Idade + "\nSexo: " + pessoa.Sexo + "\nIMC de: " + imcP.ToString("F") + "\nVocê está com obesidade");
            }
            if ((imcP >= 35) && (imcP <= 39.99))
            {
                MessageBox.Show("\nNome: " + pessoa.Nome + "\nIdade: " + pessoa.Idade + "\nSexo: " + pessoa.Sexo + "\nIMC de: " + imcP.ToString("F") + "\nVocê está com ObesidadeII(SEVERA)");
            }
            if (imcP >= 40)
            {
                MessageBox.Show("\nNome: " + pessoa.Nome + "\nIdade: " + pessoa.Idade + "\nSexo: " + pessoa.Sexo + "\nIMC de: " + imcP.ToString("F") + "\nVocê está com ObesidadeIII(MÓRBIDA)");
            }
            
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = "Masculino";
        }

        private void rbFemino_CheckedChanged(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = "Feminino";
        }

        


        }

    }


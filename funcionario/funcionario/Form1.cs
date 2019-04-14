using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcSalFamilia_Click(object sender, EventArgs e)
        {
            
            int NumDep;
            double SalB;

            NumDep = Convert.ToInt16(txtNumeroDep.Text);
            SalB = Convert.ToDouble(txtSalario.Text);

            Funcionario f1 = new Funcionario(NumDep, SalB);


            f1.Nome = Convert.ToString(txtNome.Text);
            f1.Sexo = Convert.ToString(txtSexo.Text);
           

            Double SalarioF;
            SalarioF = f1.CalcSalarioFamilia();

            txtSalarioFamilia.Text = Convert.ToString(f1.CalcSalarioFamilia());

            MessageBox.Show("Funcionário:\n" + f1.Nome + "\n" + f1.Sexo + "\n" + f1.SalarioBase + "\n" + "Tem o Salário família de:\n" + SalarioF);
            
        }
    }
}

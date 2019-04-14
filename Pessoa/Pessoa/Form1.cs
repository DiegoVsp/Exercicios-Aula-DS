using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();

            p1.Idade = Convert.ToInt16(txtIdade.Text);

            if (p1.EMaiorDeIdade() == (true))
            {
                MessageBox.Show("É maior de Idade");
            }
            else {
                MessageBox.Show("Não é maior de Idade");
            }

            
        }
    }
}

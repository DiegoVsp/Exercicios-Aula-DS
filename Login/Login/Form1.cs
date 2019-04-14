using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            string conta;
            string pass;

            conta = Convert.ToString(txtLogin.Text);
            pass = Convert.ToString(txtSenha.Text);

            Usuario usuario = new Usuario(conta,pass);

            MessageBox.Show(usuario.Validar());
            

            



        }
    }
}

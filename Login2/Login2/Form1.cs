using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

            
            txtUsuario.ForeColor = Color.DimGray;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string conta;
            string pass;

            conta = Convert.ToString(txtUsuario.Text);
            pass = Convert.ToString(txtSenha.Text);

            Usuario usuario = new Usuario(conta, pass);

            MessageBox.Show(usuario.validar());
            txtUsuario.Clear();
            txtSenha.Clear();

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.DimGray;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

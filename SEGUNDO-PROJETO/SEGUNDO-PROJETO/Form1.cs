using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEGUNDO_PROJETO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            Cliente Victor = new Cliente();
            Victor.nome = "Victor";

            Conta umaConta = new Conta();
            umaConta.titular = Victor;
            umaConta.titular.rg = "12345678-9";
            

            // Mostra o nome Victor
            MessageBox.Show(umaConta.titular.nome);

            //Mostra o texto 12345678-9
            MessageBox.Show(Victor.rg);

            

            //Deposita 250

            umaConta.Deposita(250.0);

            //Saca 150
            umaConta.Saca(100.0);

            /* Mas ainda não resolvemos o problemas de evitar que programadores façam uso
             * diretamente do atributo.
             * Qualquer um ainda pode executar o código abaixo:*/
            umaConta.saldo -= 371.0;

            //Mostra saldo atual...

            MessageBox.Show("Saldo Atual após saque: " + umaConta.saldo);
        }
    }
}

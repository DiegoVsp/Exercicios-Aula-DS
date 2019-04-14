using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DadosBancarios3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            Conta c = new Conta();

            //c.saldo = 100;  //NAO PODE ACESSAR POR SER PRIVATE

            c.Deposita(200.0);

            MessageBox.Show("saldo: " + c.PegaSaldo());

            c.Numero = 1; //funciona pois o get do Numero é público
            MessageBox.Show("numero: " + c.Numero); //funciona pois o get do Numero é público

            c.Saca(50.0);

            MessageBox.Show("Saldo " + c.Saldo);

            
            Cliente cli = new Cliente();
            Cliente titular = cli;
            titular.setnome = "maria";
            titular.Cpf = "999999999-0";
            titular.Rg = "44.444.444-0";
            titular.Endereco = "Av.Maria do sol";
            

            MessageBox.Show(titular.setnome+" "+titular.Cpf+" "+titular.Rg+" "+titular.Endereco );
            
            
            
            
            
            
            
            
            
           
           
        }
        
        
        
    }
}

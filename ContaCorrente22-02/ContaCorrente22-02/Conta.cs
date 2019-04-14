using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaCorrente22_02
{
    class Conta
    {
        private int numero;
        private double saldo;

       


        public int Numero       
         {
            get { return numero; }
            set { numero = value; }
         }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= this.Saldo) 
            {
                this.saldo -= valor;
            }
        }

        //PEGA SALDO - MÉTODO
        public double PegaSaldo()
        {
            return this.saldo;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEGUNDO_PROJETO
{
    class Conta
    {
        // numero,titular e saldo são atributos do objeto
        //public string titular

        public int numero;
        public double saldo;

        public Cliente titular;

        public void Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
            }
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
    }
}

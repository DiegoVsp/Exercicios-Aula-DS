using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DadosBancarios3
{
    class Conta
    {
        //Atributos private não podem ser acessados diretamente
        //Atributos declarados em minusculo
        private int numero;
        private double saldo;

        //Getters e Setters declarados em Maiusculas
        public int Numero
        {
            get { return numero; } // Retorna valor de Número
            set { numero = value; }// Atribui valor para Numero
        }

        public double Saldo
        {
            get { return saldo; } //Retorna valor de Saldo
            set { saldo = value; } //Atribui valor para Saldo
        }

        //Atributo titular recebendo classe Cliente
        //Todos atributos de cliente são inseridos em titular


        public Cliente titular;
        
        
       
        
        
        //Métodos
        public void Saca(double valor)
        {
            this.saldo -= valor;
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public double PegaSaldo()
        {
            return this.saldo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    class Diretor
    {
        public Diretor() 
        {
            
        }
        private int codigo;
        private string cartTrab;
        private double bonificacao;
        private double salario;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        

        public string CartTrab
        {
            get { return cartTrab; }
            set { cartTrab = value; }
        }
        

        public double Bonificacao
        {
            get { return bonificacao; }
            set { bonificacao = value; }
        }
        

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }


    }
}

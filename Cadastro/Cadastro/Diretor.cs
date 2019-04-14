using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Diretor:Pessoa
    {
        private int codigo;
        private string cartTrab;
        private double bonificacao;
        private double salario;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string CartTrab
        {
            get
            {
                return cartTrab;
            }

            set
            {
                cartTrab = value;
            }
        }

        public double Bonificacao
        {
            get
            {
                return bonificacao;
            }

            set
            {
                bonificacao = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
        public double SalarioLiq()
        {
            return bonificacao + salario;

        }
        public string Mostrar()
        {
            return "Salario Liquido do Diretor: " + SalarioLiq().ToString("C") + "\n---***Cadastrado com Sucesso!***---";
        }
    }
}

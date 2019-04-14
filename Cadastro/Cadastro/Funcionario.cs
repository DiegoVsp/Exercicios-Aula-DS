using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Funcionario:Pessoa
    {
        private int codigo;
        private string cartTrab;
        private string cargo;
        private double adiclNotur;
        private double salario;
        private double inss;

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

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public double AdiclNotur
        {
            get
            {
                return adiclNotur;
            }

            set
            {
                adiclNotur = value;
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

        public double Inss
        {
            get
            {
                return inss;
            }

            set
            {
                inss = value;
            }
        }
        public double SalarioLiq()
        {
            return (adiclNotur + salario) - inss;
        }

        public double Mostrar()
        {
            return SalarioLiq();
        }
    }
}

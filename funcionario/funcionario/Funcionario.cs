using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace funcionario
{
    class Funcionario
    {
        private string nome;
        private string sexo;
        private int numeroDependetes;
        private double salarioBase;
        private double salarioFamilia;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        

        public int NumeroDependetes
        {
            get { return numeroDependetes; }
            set { numeroDependetes = value; }
        }
        

        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        public Funcionario() 
        {
        
        }
        
        public Funcionario(int NumDep, double SalB)
        {
            numeroDependetes = NumDep;
            salarioBase = SalB;
        }

        public double CalcSalarioFamilia()
        {
            return salarioFamilia = (salarioBase*0.5)*numeroDependetes;
        }


    }
}

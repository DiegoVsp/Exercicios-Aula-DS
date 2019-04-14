using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private string sexo;
        private double altura;
        private double peso;
        private double imc;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Pessoa()
        {
            
        }

        public Pessoa(double tamanho, double gordura) 
        {
            altura = tamanho;
            peso = gordura;
        }

        public double CalcImc() 
        {

            return imc = peso / (altura * altura);
            
            
        }

       
    }
}

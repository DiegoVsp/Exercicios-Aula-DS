using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aluno
{
    class Aluno
    {
        private string matricula;


        private string nome;


        private double nota1;


        private double nota2;

        private double media;

        


       
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public double Media
        {
            get { return media; }
            set { media = value; }
        }

        public void TiraMedia()
        {
            this.media = (nota1 + nota2) / 2;
            
        }
    }
}

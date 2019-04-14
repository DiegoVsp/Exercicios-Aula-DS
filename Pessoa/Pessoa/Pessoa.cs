using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pessoa
{
    class Pessoa
    {
        private string nome;
        private int idade;


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

        
        public Boolean EMaiorDeIdade()
        {
            if (idade >= 18)
            {                
                return true;
            }
            else
            {
                return false;
            }

            
        }
        
    }
}

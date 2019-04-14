using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaCorrente22_02
{
    class Cliente
    {
        private string nome;
        private string cpf;        
        private string rg;        
        private string endereco;

        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

    }
}

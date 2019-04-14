using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente_Fornecedor
{
    class Pessoa
    {
        public string nome;
        public string endereco;
        public string telefone;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }        

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }        

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public virtual String VerificarDocumento()
        {
            String mensagem;
            mensagem = ("Pessoa não possui documento");
            return mensagem;
        }
    }
}

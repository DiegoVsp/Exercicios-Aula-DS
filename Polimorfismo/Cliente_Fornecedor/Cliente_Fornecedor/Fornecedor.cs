using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente_Fornecedor
{
    class Fornecedor:Pessoa
    {
        private string CNPJ = "";

        public string CNPJ1
        {
            get { return CNPJ; }
            set { CNPJ = value; }
        }
        public override String VerificarDocumento()
        {
            String mensagem = "Verificar seus documentos! CNPJ";
            return mensagem;
        }

    }
}

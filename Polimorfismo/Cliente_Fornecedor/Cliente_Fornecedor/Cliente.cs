using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente_Fornecedor
{
    class Cliente:Pessoa
    {
        private string CPF;

        public string CPF1
        {
            get { return CPF; }
            set { CPF = value; }
        }

        public override String VerificarDocumento()
        {
            String mensagem = "Verifique seus documentos! CPF";
            return mensagem;
        }


    }
}

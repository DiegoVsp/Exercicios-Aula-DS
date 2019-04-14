using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valor_Ingresso
{
    class CamaroteInferior:IngressoVip
    {
        private double valorAdicional;
        private int lugar;

        public int Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public double ValorAdicional
        {
            get { return valorAdicional; }
            set { valorAdicional = value; }
        }

        public override double ImprimirValor() 
        {
            return PrecoVip + valorAdicional;
        }

    }
}

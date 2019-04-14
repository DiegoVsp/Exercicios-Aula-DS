using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Cientifica
{
    class Cientifica : Calculadora       

    {
        
        public double raizQuadrada()
        {
            return Resultado = Math.Sqrt(Numero1);
            
        }
        public double potencia()
        {
            return Resultado = Math.Pow(Numero1, Numero2);
        }
        public override double divisao()
        {
            if (Numero1 > 0)
            {
                Resultado = Numero1 / Numero2;
            }
            return Resultado;
        }

        public override double multiplicacao()
        {
            return Resultado = Numero1 * Numero2;
        }

        public override double Soma()
        {
            return Resultado = Numero1 + Numero2;
        }

        public override double Subtracao()
        {
            return Resultado = Numero1 - Numero2;
        }
    }
}

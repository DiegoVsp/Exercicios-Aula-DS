using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcVolume
{
    class Retangulo
    {
        private double comprimento;        
        private double largura;      
        private double altura;        
        private double volume;



        public double Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }
        public double Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public double Calcular() 
        {
            this.volume = this.comprimento * this.largura * this.altura;
            return this.volume;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinePromo
{
    class Cinema
    {
        private string filme;
        private string diaDaSemana;
        private int nroSala;
        private double precoFilme = 27.00;
        private double desconto;

        public double Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }
        


        public double PrecoFilme
        {
            get { return precoFilme; }
            set { precoFilme = value; }
        }

        public string Filme
        {
            get { return filme; }
            set { filme = value; }
        }        

        public string DiaDaSemana
        {
            get { return diaDaSemana; }
            set { diaDaSemana = value; }
        }        

        public int NroSala
        {
            get { return nroSala; }
            set { nroSala = value; }
        }
        public Cinema() 
        {
            
        }

        public Cinema(string movie) 
        {
            filme = movie;
        }
        public  string MostrarDados() 
        {
            
            return "Filme: "+filme+"\nem exibição na sala "+nroSala;

        }

        public void CalcDesconto() 
        
        {
            if (this.diaDaSemana == ("Quarta")) {
                desconto = precoFilme * 0.5;
            }
            
            
        }




    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Professor:Pessoa
    {
        private int codigo;
        private string graducao;
        private string especialidade;
        private string cartTrabalho;
        private double vlHora;
        private double horaTrab;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Graducao
        {
            get
            {
                return graducao;
            }

            set
            {
                graducao = value;
            }
        }

        public string Especialidade
        {
            get
            {
                return especialidade;
            }

            set
            {
                especialidade = value;
            }
        }

        public string CartTrabalho
        {
            get
            {
                return cartTrabalho;
            }

            set
            {
                cartTrabalho = value;
            }
        }

        public double VlHora
        {
            get
            {
                return vlHora;
            }

            set
            {
                vlHora = value;
            }
        }

        public double HoraTrab
        {
            get
            {
                return horaTrab;
            }

            set
            {
                horaTrab = value;
            }
        }
        public double SalarioLiq()
        {
            return vlHora * horaTrab;
        }
        public string Mostrar()
        {
            return "Salario Liquido do Professor: " + SalarioLiq().ToString("C") + "\n---***Cadastrado com Sucesso!***---";
        }
    }
}

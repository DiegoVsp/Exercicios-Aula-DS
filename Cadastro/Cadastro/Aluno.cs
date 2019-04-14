using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Aluno:Pessoa
    {
        private string rm;
        private string curso;
        private string modulo;

        public string Rm
        {
            get
            {
                return rm;
            }

            set
            {
                rm = value;
            }
        }

        public string Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }

        public string Modulo
        {
            get
            {
                return modulo;
            }

            set
            {
                modulo = value;
            }
        }
        public string Mostrar()
        {
            return "Aluno "+this.rm +" do curso de "+ this.curso +" do "+ this.modulo+"º módulo"+"\n Cadastrado com sucesso!" ;
        }
    }
}

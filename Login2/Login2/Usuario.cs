using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login2
{
    class Usuario
    {
        private string login = "admin";
        private string senha = "123";

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public Usuario() 
        {
            
        }
        public Usuario(string conta, string pass) 
        {
            login = conta;
            senha = pass;
        }

        public string validar() 
        {
            if (login.Equals("admin") && senha.Equals("123"))
            {
                return "Logado com sucesso!";
            }
            else {
                return "Dados Incorretos";
            }
        }
    }
}

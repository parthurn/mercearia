﻿using Nucleo.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Modelo
{
    public class Usuario
    {
        public enum Tipo
        {
            ADM,
            VENDEDOR
        }

        private int _id;
        public virtual int Id { get { return _id; } }

        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }

        public static string SenhaReset = "12345678";

        public static List<Usuario> ListaUsuarios()
        {
            List<Usuario> lista = new List<Usuario>
            {
                new Usuario { Login = "ADM", Senha = Criptografia.ON("1234") },
                new Usuario { Login = "VENDEDOR", Senha = Criptografia.ON("5678") }
            };

            return lista;
        }
    }
}

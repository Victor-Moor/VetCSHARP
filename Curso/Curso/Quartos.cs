﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Quartos
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Quartos(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }
    }
}

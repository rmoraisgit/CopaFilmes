using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Models
{
    public class Filme
    {
        public string Id { get; private set; }
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public decimal Nota { get; private set; }
        public int Colocacao { get; private set; }
    }
}

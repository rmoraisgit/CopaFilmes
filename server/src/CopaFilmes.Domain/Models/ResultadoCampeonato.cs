using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Models
{
    public class ResultadoCampeonato
    {
        public ICollection<Filme> Filmes { get; private set; }
    }
}

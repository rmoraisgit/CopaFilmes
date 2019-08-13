using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain.Models
{
    public class ResultadoCampeonato
    {
        public ResultadoCampeonato()
        {
            Filmes = new List<Filme>();
        }

        public IList<Filme> Filmes { get; private set; }

        public IList<Filme> OrdenarPorOrdemAlfabetica(IList<Filme> filmes)
        {
            return filmes.OrderBy(f => f.Titulo).ToList();
        }
    }
}

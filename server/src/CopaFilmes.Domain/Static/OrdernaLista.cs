using CopaFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain.Static
{
    public static class OrdernaLista
    {
        public static IList<Filme> PorOrdemAlfabetica(IList<Filme> filme)
        {
            return filme.OrderBy(f => f.Titulo).ToList();
        }

        public static IList<Filme> PorMaiorNota(IList<Filme> filme)
        {
            return filme.OrderByDescending(f => f.Nota).ToList();
        }
    }
}

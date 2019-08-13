using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain.Models.Static
{
    public static class OrdernaLista
    {
        public static IList<Filme> PorOrdemAlfabetica(IList<Filme> lista)
        {
            return lista.OrderBy(l => l.Titulo).ToList();
        }
    }
}

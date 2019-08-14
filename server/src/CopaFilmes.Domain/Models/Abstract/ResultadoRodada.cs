using CopaFilmes.Domain.Models.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain.Models.Abstract
{
    public abstract class ResultadoRodada
    {
        public ResultadoRodada()
        {
            Rodada = new Rodada();
        }

        public Rodada Rodada { get; set; }

        public abstract Rodada ObterResultado(IList<Filme> filmes);

        protected bool HouveEmpate(Filme f1, Filme f2)
        {
            return f1.Nota == f2.Nota;
        }

        protected Filme Desempatar(Filme f1, Filme f2)
        {
            var listaFilmes = new List<Filme>
            {
                f1,
                f2
            };

            return OrdernaLista.PorOrdemAlfabetica(listaFilmes).First();
        }

        protected Filme JogarRodada(Filme f1, Filme f2)
        {
            return f1.Nota > f2.Nota ? f1 : f2;
        }
    }
}

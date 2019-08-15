using CopaFilmes.Domain.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Models.Abstract
{
    public class ResultadoUltimaRodada : ResultadoRodada
    {
        public override Rodada ObterResultado(IList<Filme> filmes)
        {
            Rodada.SetarRodada(3);
            Rodada.Filmes.Clear();
            Rodada.Filmes.AddRange(OrdenarPrimeiroSegundoLugar(filmes));
            return Rodada;
        }

        private IList<Filme> OrdenarPrimeiroSegundoLugar(IList<Filme> filmes)
        {
            int indiceCrescente = 0;

            if (HouveEmpate(filmes[indiceCrescente], filmes[indiceCrescente + 1]))
                return OrdernaLista.PorOrdemAlfabetica(filmes);

            else
                return OrdernaLista.PorMaiorNota(filmes);
        }
    }
}


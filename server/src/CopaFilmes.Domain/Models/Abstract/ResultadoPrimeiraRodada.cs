using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Models.Abstract
{
    public class ResultadoPrimeiraRodada : ResultadoRodada
    {
        public override Rodada ObterResultado(IList<Filme> filmes)
        {
            int indiceCrescente = 0;
            int indiceDecrescente = filmes.Count - 1;
            Rodada.SetarRodada(1);

            while (indiceCrescente != indiceDecrescente + 1)
            {
                if (HouveEmpate(filmes[indiceCrescente], filmes[indiceDecrescente]))
                {
                    Rodada.Filmes.Add(Desempatar(filmes[indiceCrescente], filmes[indiceDecrescente]));
                }

                else
                {
                    Rodada.Filmes.Add(JogarRodada(filmes[indiceCrescente], filmes[indiceDecrescente]));
                }

                indiceCrescente++;
                indiceDecrescente--;
            }

            return Rodada;
        }
    }
}

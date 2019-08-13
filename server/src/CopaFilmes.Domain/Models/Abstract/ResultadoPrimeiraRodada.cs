using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Models.Abstract
{
    public class ResultadoPrimeiraRodada : ResultadoRodada
    {
        public override ResultadoCampeonato ObterResultado(IList<Filme> filmes)
        {
            int indiceCrescente = 0;
            int indiceDecrescente = filmes.Count - 1;

            while (indiceCrescente != indiceDecrescente + 1)
            {
                if (HouveEmpate(filmes[indiceCrescente], filmes[indiceDecrescente]))
                {
                    ResultadoCampeonato.Filmes.Add(Desempatar(filmes[indiceCrescente], filmes[indiceDecrescente]));
                }

                else
                {
                    ResultadoCampeonato.Filmes.Add(JogarRodada(filmes[indiceCrescente], filmes[indiceDecrescente]));
                }

                indiceCrescente++;
                indiceDecrescente--;
            }

            return ResultadoCampeonato;
        }
    }
}

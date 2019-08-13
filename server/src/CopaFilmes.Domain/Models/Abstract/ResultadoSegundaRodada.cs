using CopaFilmes.Domain.Models.Abstract;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Models.Abstract
{
    public class ResultadoSegundaRodada : ResultadoRodada
    {
        public override ResultadoCampeonato ObterResultado(IList<Filme> filmes)
        {
            int indiceCrescente = 0;

            while (indiceCrescente != filmes.Count)
            {

                if (HouveEmpate(filmes[indiceCrescente], filmes[indiceCrescente + 1]))
                {
                    // logica pra determinar vencedor
                }

                else
                {
                    ResultadoCampeonato.Filmes.Add(JogarRodada(filmes[indiceCrescente], filmes[indiceCrescente + 1]));
                }

                indiceCrescente += 2;
            }

            return ResultadoCampeonato;
        }
    }
}
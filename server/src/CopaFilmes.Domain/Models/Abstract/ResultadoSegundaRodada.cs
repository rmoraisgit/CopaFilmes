using CopaFilmes.Domain.Models.Abstract;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Models.Abstract
{
    public class ResultadoSegundaRodada : ResultadoRodada
    {
        public override Rodada ObterResultado(IList<Filme> filmes)
        {
            int indiceCrescente = 0;
            Rodada.SetarRodada(2);

            while (indiceCrescente != filmes.Count)
            {

                if (HouveEmpate(filmes[indiceCrescente], filmes[indiceCrescente + 1]))
                {
                    Rodada.Filmes.Add(Desempatar(filmes[indiceCrescente], filmes[indiceCrescente + 1]));
                }

                else
                {
                    Rodada.Filmes.Add(JogarRodada(filmes[indiceCrescente], filmes[indiceCrescente + 1]));
                }

                indiceCrescente += 2;
            }

            return Rodada;
        }
    }
}
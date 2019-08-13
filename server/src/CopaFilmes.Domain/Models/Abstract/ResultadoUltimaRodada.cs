using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Models.Abstract
{
    public class ResultadoUltimaRodada : ResultadoRodada
    {
        public override ResultadoCampeonato ObterResultado(IList<Filme> filmes)
        {
            throw new NotImplementedException();
        }
    }
}

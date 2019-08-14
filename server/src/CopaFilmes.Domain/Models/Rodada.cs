using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain.Models
{
    public class Rodada
    {
        public Rodada()
        {
            Filmes = new List<Filme>();
        }

        public List<Filme> Filmes { get; private set; }
        public int NumeroRodada { get; private set; }

        public void SetarRodada(int numeroRodada)
        {
            NumeroRodada = numeroRodada;
        }
    }
}

using CopaFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Interfaces
{
    public interface ICopaFilmesService
    {
        void RealizarCampeonato(IList<Filme> filmes);
    }
}

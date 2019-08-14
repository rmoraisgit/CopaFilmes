using CopaFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Interfaces
{
    public interface ICopaFilmesService
    {
        Rodada RealizarCampeonato(IList<Filme> filmes);
    }
}

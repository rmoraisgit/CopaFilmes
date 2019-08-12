using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Models;
using CopaFilmes.Domain.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain.Services
{
    public class CopaFilmesService :  BaseService, ICopaFilmesService
    {
        public CopaFilmesService(INotificador notificador) : base(notificador) { }
        
        public void RealizarCampeonato(ICollection<Filme> filmes)
        {
            if(filmes.Count != 8)
            {
                Notificar("Somente 8 filmes devem ser selecionados.");
                return;
            }

            filmes = OrdenarPorOrdemAlfabetica(filmes);
        }

        private ICollection<Filme> OrdenarPorOrdemAlfabetica(ICollection<Filme> filmes)
        {
            return filmes.OrderBy(f => f.Titulo).ToList();
        }
    }
}

using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Models;
using CopaFilmes.Domain.Models.Abstract;
using CopaFilmes.Domain.Models.Static;
using CopaFilmes.Domain.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain.Services
{
    public class CopaFilmesService : BaseService, ICopaFilmesService
    {
        public CopaFilmesService(INotificador notificador) : base(notificador) { }

        public void RealizarCampeonato(IList<Filme> filmes)
        {
            if (filmes.Count != 8)
            {
                Notificar("Somente 8 filmes devem ser selecionados.");
                return;
            }

            filmes = OrdernaLista.PorOrdemAlfabetica(filmes);

            var resultadoPrimeiraRodada = RodadaFactory(1).ObterResultado(filmes);
            var resultadoSegundaRodada = RodadaFactory(2).ObterResultado(resultadoPrimeiraRodada.Filmes);
        }

        private ResultadoRodada RodadaFactory(int numeroRodada)
        {
            switch (numeroRodada)
            {
                case 1:
                    return new ResultadoPrimeiraRodada();
                case 2:
                    return new ResultadoSegundaRodada();
                case 3:
                    return new ResultadoUltimaRodada();
                default:
                    var errorMsg = "Número da rodada inválida";
                    Notificar(errorMsg);
                    return null;
            }
        }
    }
}

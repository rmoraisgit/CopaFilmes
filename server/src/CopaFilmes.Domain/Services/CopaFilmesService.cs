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

        public Rodada RealizarCampeonato(IList<Filme> filmes)
        {
            filmes = OrdernaLista.PorOrdemAlfabetica(filmes);

            var resultadoPrimeiraRodada = RodadaFactory(1).ObterResultado(filmes);
            var resultadoSegundaRodada = RodadaFactory(2).ObterResultado(resultadoPrimeiraRodada.Filmes);
            var resultadoFinal = RodadaFactory(3).ObterResultado(resultadoSegundaRodada.Filmes);

            return resultadoFinal;
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
                    Notificar("Número da rodada inválida");
                    return null;
            }
        }
    }
}

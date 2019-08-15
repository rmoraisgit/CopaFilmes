using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Models;
using CopaFilmes.Domain.Models.Abstract;
using CopaFilmes.Domain.Static;
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
            var rodada = new Rodada();

            if (!FilmesEstaoValidos(filmes))
            {
                rodada.SinalizarErro();
                return rodada;
            }

            if (filmes.Count() != 8)
            {
                Notificar("Selecione 8 filmes para iniciar o campeonato");

                rodada.SinalizarErro();
                return rodada;
            }

            filmes = OrdernaLista.PorOrdemAlfabetica(filmes);

            var resultadoPrimeiraRodada = RodadaFactory(NivelRodada.PrimeiraRodada).ObterResultado(filmes);
            var resultadoSegundaRodada = RodadaFactory(NivelRodada.SegundaRodada).ObterResultado(resultadoPrimeiraRodada.Filmes);
            var resultadoFinal = RodadaFactory(NivelRodada.UltimaRodada).ObterResultado(resultadoSegundaRodada.Filmes);

            return resultadoFinal;
        }

        private ResultadoRodada RodadaFactory(NivelRodada nivelRodada)
        {
            switch (nivelRodada)
            {
                case NivelRodada.PrimeiraRodada:
                    return new ResultadoPrimeiraRodada();
                case NivelRodada.SegundaRodada:
                    return new ResultadoSegundaRodada();
                case NivelRodada.UltimaRodada:
                    return new ResultadoUltimaRodada();
                default:
                    Notificar("Número da rodada inválida");
                    return null;
            }
        }

        private bool FilmesEstaoValidos(IList<Filme> filmes)
        {
            foreach (var filme in filmes)
            {
                if (!filme.EhValido())
                {
                    Notificar(filme.ValidationResult);
                    return false;
                }
            }
            return true;
        }
    }
}
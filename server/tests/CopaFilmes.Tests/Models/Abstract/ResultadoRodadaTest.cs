using CopaFilmes.Domain.Models;
using CopaFilmes.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CopaFilmes.Tests.Models.Abstract
{
    public class ResultadoRodadaTest
    {
        [Fact]
        public void ObterResultadoEmpate()
        {
            var resultadoRodada = new ResultadoPrimeiraRodada();

            var listaFilmes = new List<Filme>
            {
                new Filme("tt3778644", "Han Solo: Uma História Star Wars", 2018, 8.0),
                new Filme("tt5463162", "Deadpool 2", 2018, 8.0),
            };


            var listaFilmesDesempatada = new List<Filme>
            {
                new Filme("tt5463162", "Deadpool 2", 2018, 8.0),
                new Filme("tt3778644", "Han Solo: Uma História Star Wars", 2018, 8.0),
            };

            var resultadoEmpate = resultadoRodada.ObterResultado(listaFilmes);

            for (int i = 0; i < resultadoEmpate.Filmes.Count; i++)
            {
                Assert.Equal(resultadoEmpate.Filmes[i].Id, listaFilmesDesempatada[i].Id);
                Assert.Equal(resultadoEmpate.Filmes[i].Titulo, listaFilmesDesempatada[i].Titulo);
                Assert.Equal(resultadoEmpate.Filmes[i].Ano, listaFilmesDesempatada[i].Ano);
                Assert.Equal(resultadoEmpate.Filmes[i].Nota, listaFilmesDesempatada[i].Nota);
            }
        }

        [Fact]
        public void ObterResultadoPrimeiraRodada()
        {
            var resultadoRodada = new ResultadoPrimeiraRodada();

            var listaFilmes = new List<Filme>
            {
                new Filme("tt5463162", "Deadpool 2", 2018, 8.1),
                new Filme("tt3778644", "Han Solo: Uma História Star Wars", 2018, 7.2),
                new Filme("tt7784604", "Hereditário", 2018, 7.8),
                new Filme("tt4881806", "Jurassic World: Reino Ameaçado", 2018, 6.7),
                new Filme("tt5164214", "Oito Mulheres e um Segredo", 2018, 6.3),
                new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5),
                new Filme("tt3501632", "Thor: Ragnarok", 2017, 7.9),
                new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8)
            };


            var listaComFilmesVencedores = new List<Filme>
            {
                new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8),
                new Filme("tt3501632", "Thor: Ragnarok", 2017, 7.9),
                new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5),
                new Filme("tt4881806", "Jurassic World: Reino Ameaçado", 2018, 6.7)
            };

            var resultado = resultadoRodada.ObterResultado(listaFilmes);

            for (int i = 0; i < resultado.Filmes.Count; i++)
            {
                Assert.Equal(resultado.Filmes[i].Id, listaComFilmesVencedores[i].Id);
                Assert.Equal(resultado.Filmes[i].Titulo, listaComFilmesVencedores[i].Titulo);
                Assert.Equal(resultado.Filmes[i].Ano, listaComFilmesVencedores[i].Ano);
                Assert.Equal(resultado.Filmes[i].Nota, listaComFilmesVencedores[i].Nota);
            }
        }

        [Fact]
        public void ObterResultadoSegundaRodada()
        {
            var resultadoRodada = new ResultadoSegundaRodada();

            var listaFilmes = new List<Filme>
            {
                new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8),
                new Filme("tt3501632", "Thor: Ragnarok", 2017, 7.9),
                new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5),
                new Filme("tt4881806", "Jurassic World: Reino Ameaçado", 2018, 6.7)
            };

            var listaComFilmesVencedores = new List<Filme>
            {
                new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8),
                new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5)
            };

            var resultado = resultadoRodada.ObterResultado(listaFilmes);

            for (int i = 0; i < resultado.Filmes.Count; i++)
            {
                Assert.Equal(resultado.Filmes[i].Id, listaComFilmesVencedores[i].Id);
                Assert.Equal(resultado.Filmes[i].Titulo, listaComFilmesVencedores[i].Titulo);
                Assert.Equal(resultado.Filmes[i].Ano, listaComFilmesVencedores[i].Ano);
                Assert.Equal(resultado.Filmes[i].Nota, listaComFilmesVencedores[i].Nota);
            }
        }

        [Fact]
        public void ObterResultadoUltimaRodada()
        {
            var resultadoRodada = new ResultadoUltimaRodada();

            var listaFilmes = new List<Filme>
            {
                new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8),
                new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5)
            };

            var listaComFilmesVencedores = new List<Filme>
            {
                new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8),
                new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5)
            };

            var resultado = resultadoRodada.ObterResultado(listaFilmes);

            for (int i = 0; i < resultado.Filmes.Count; i++)
            {
                Assert.Equal(resultado.Filmes[i].Id, listaComFilmesVencedores[i].Id);
                Assert.Equal(resultado.Filmes[i].Titulo, listaComFilmesVencedores[i].Titulo);
                Assert.Equal(resultado.Filmes[i].Ano, listaComFilmesVencedores[i].Ano);
                Assert.Equal(resultado.Filmes[i].Nota, listaComFilmesVencedores[i].Nota);
            }
        }
    }
}

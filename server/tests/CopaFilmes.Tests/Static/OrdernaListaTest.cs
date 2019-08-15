using CopaFilmes.Domain.Static;
using CopaFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CopaFilmes.Tests.Static
{
    public class OrdenaListaTest
    {
        [Fact]
        public void PorOrdemAlfabetica()
        {
            var listaFilmesOrdenada = new List<Filme>
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

            var listaFilmesDesordenada = new List<Filme>
            {
                new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5),
                new Filme("tt4881806", "Jurassic World: Reino Ameaçado", 2018, 6.7),
                new Filme("tt5164214", "Oito Mulheres e um Segredo", 2018, 6.3),
                new Filme("tt7784604", "Hereditário", 2018, 7.8),
                new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8),
                new Filme("tt5463162", "Deadpool 2", 2018, 8.1),
                new Filme("tt3778644", "Han Solo: Uma História Star Wars", 2018, 7.2),
                new Filme("tt3501632", "Thor: Ragnarok", 2017, 7.9)
            };

            var listaAposOrdenacao = OrdernaLista.PorOrdemAlfabetica(listaFilmesDesordenada);

            for (int i = 0; i < listaAposOrdenacao.Count; i++)
            {
                Assert.Equal(listaAposOrdenacao[i].Id, listaFilmesOrdenada[i].Id);
                Assert.Equal(listaAposOrdenacao[i].Titulo, listaFilmesOrdenada[i].Titulo);
                Assert.Equal(listaAposOrdenacao[i].Ano, listaFilmesOrdenada[i].Ano);
                Assert.Equal(listaAposOrdenacao[i].Nota, listaFilmesOrdenada[i].Nota);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Services.Api.ViewModels
{
    public class ResultadoCampeonatoViewModel
    {
        public ICollection<FilmeViewModel> Filmes  { get; set; }
    }
}

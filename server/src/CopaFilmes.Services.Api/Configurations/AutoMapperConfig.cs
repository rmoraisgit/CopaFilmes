using AutoMapper;
using CopaFilmes.Domain.Models;
using CopaFilmes.Services.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Services.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Filme, FilmeViewModel>().ReverseMap();
            CreateMap<Rodada, ResultadoCampeonatoViewModel>().ReverseMap();
        }
    }
}

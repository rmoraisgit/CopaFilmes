using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Models;
using CopaFilmes.Domain.Notificacoes;
using CopaFilmes.Services.Api.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CopaFilmesController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly INotificador _notificador;
        private readonly ICopaFilmesService _copaFilmesService;

        public CopaFilmesController(IMapper mapper,
                                    INotificador notificador,
                                    ICopaFilmesService copaFilmesService) : base(notificador)
        {
            _mapper = mapper;
            _copaFilmesService = copaFilmesService;
        }

        [HttpPost("inicio-jogo")]
        public ActionResult<ResultadoCampeonatoViewModel> IniciarCampeonato([FromBody] IList<FilmeViewModel> filmesViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
       
            var filmes = _mapper.Map<IList<Filme>>(filmesViewModel);

            var resultadoCampeonato = _mapper.Map<ResultadoCampeonatoViewModel>(_copaFilmesService.RealizarCampeonato(filmes));

            if(resultadoCampeonato.HouveErro) return CustomResponse(resultadoCampeonato);

            return CustomResponse(resultadoCampeonato);
        }
    }
}
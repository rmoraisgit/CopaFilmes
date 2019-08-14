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

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("inicio-jogo")]
        public ActionResult<ResultadoCampeonatoViewModel> IniciarCampeonato([FromBody] IList<FilmeViewModel> filmesViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
            if (filmesViewModel.Count != 8)
            {
               NotificarErro("Selecione 8 filmes para iniciar o campeonato");
                return CustomResponse(filmesViewModel);
            }

            var filmes = _mapper.Map<IList<Filme>>(filmesViewModel);

            var resultadoCampeonato = _mapper.Map<ResultadoCampeonatoViewModel>(_copaFilmesService.RealizarCampeonato(filmes));

            if (resultadoCampeonato.Equals(null)) return CustomResponse("Erro ao gerar campeonato.");

            return CustomResponse(resultadoCampeonato);
        }
    }
}
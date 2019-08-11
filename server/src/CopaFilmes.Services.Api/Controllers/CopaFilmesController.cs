using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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

        public CopaFilmesController(IMapper mapper,
                                    INotificador notificador) : base(notificador)
        {
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("inicio-jogo")]
        public async Task<ActionResult<FilmeViewModel>> IniciarCampeonato([FromBody] List<FilmeViewModel> filmesViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var filme = _mapper.Map<ICollection<Filme>>(filmesViewModel);


            // await _compraService.Registrar(compra);

            return CustomResponse(filmesViewModel);
        }
    }
}
using AutoMapper;
using LocadoraApp.Application.ViewModel;
using LocadoraApp.Data.Services.Interfaces;
using LocadoraApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LocadoraApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroService _generoService;

        public GeneroController(IGeneroService generoService)
        {
            _generoService = generoService;
        }

        // GET: api/Genero
        [HttpGet]
        public IActionResult GetAll()
        {
            var generoViewModel = Mapper.Map<IEnumerable<GeneroViewModel>>(_generoService.BuscarTodos());
            return Ok(generoViewModel);
        }

        // GET: api/Genero/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var generoViewModel = Mapper.Map<GeneroViewModel>(_generoService.BuscarGenero(id));
            return Ok(generoViewModel);
        }

        // POST: api/Genero
        [HttpPost]
        public IActionResult Post([FromBody] Genero genero)
        {
            _generoService.CadastrarGenero(genero);
            return Created("Sucesso", genero);
        }

        // PUT: api/Genero/5
        [HttpPut]
        public IActionResult Put([FromBody] Genero genero)
        {
            _generoService.Editar(genero);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _generoService.DeletarGenero(id);
            return Ok();
        }
    }
}

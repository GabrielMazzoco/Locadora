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
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeService _filmeService;

        public FilmeController(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        // GET: api/Filme
        [HttpGet]
        public IActionResult GetAll()
        {
            var filmeViewModel = Mapper.Map<IEnumerable<FilmeViewModel>>(_filmeService.BuscarTodos());
            return Ok(filmeViewModel);
        }

        // GET: api/Filme/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var filmeViewModel = Mapper.Map<FilmeViewModel>(_filmeService.BuscarFilme(id));
            return Ok(filmeViewModel);
        }

        // POST: api/Filme
        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            _filmeService.CadastrarFilme(filme);
            return Created("Sucesso", filme);
        }

        // PUT: api/Filme/5
        [HttpPut]
        public IActionResult Put([FromBody] Filme filme)
        {
            _filmeService.Editar(filme);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _filmeService.DeletarFilme(id);
            return Ok();
        }
    }
}

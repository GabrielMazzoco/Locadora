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
    public class DiretorController : ControllerBase
    {
        private readonly IDiretorService _diretorService;

        public DiretorController(IDiretorService diretorService)
        {
            _diretorService = diretorService;
        }

        // GET: api/Diretor
        [HttpGet]
        public IActionResult GetAll()
        {
            var diretorViewModel = Mapper.Map<IEnumerable<DiretorViewModel>>(_diretorService.BuscarTodos());
            return Ok(diretorViewModel);
        }

        // GET: api/Diretor/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var diretorViewModel = Mapper.Map<DiretorViewModel>(_diretorService.BuscarDiretor(id));
            return Ok(diretorViewModel);
        }

        // POST: api/Diretor
        [HttpPost]
        public IActionResult Post([FromBody] Diretor diretor)
        {
            _diretorService.CadastrarDiretor(diretor);
            return Created("Sucesso", diretor);
        }

        // PUT: api/Diretor/5
        [HttpPut]
        public IActionResult Put([FromBody] Diretor diretor)
        {
            _diretorService.Editar(diretor);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _diretorService.DeletarDiretor(id);
            return Ok();
        }
    }
}

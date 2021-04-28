using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webAPI.Domains;
using senai.hroads.webAPI.Interfaces;
using senai.hroads.webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]

    public class HabilidadesController : ControllerBase
    {

        private IHabilidadeRepository _habilidadeRepository { get; set; }


        public HabilidadesController()
        {

            _habilidadeRepository = new HabilidadeRepository();

        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_habilidadeRepository.ListarHabilidades());
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_habilidadeRepository.BuscarPorId(id));  // status code 200
        }



        [HttpPost]
        public IActionResult Post(Habilidade novaHabilidade)
        {
            _habilidadeRepository.CadastrarHabilidade(novaHabilidade);

            return StatusCode(201);  // status code "created"
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Habilidade habilidadeAtualizada)
        {

            _habilidadeRepository.AtualizarHabilidade(id, habilidadeAtualizada);

            return NoContent();  // status code 204

        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _habilidadeRepository.DeletarHabilidade(id);

            return StatusCode(204);
        }


        [HttpGet("tiposhabilidades")]
        public IActionResult GetTypesAbilities()
        {
            return Ok(_habilidadeRepository.ListarTiposHabilidade());
        }

    
    }
}
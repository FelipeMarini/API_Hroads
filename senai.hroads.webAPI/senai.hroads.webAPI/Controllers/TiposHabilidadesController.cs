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

    public class TiposHabilidadesController : ControllerBase
    {

        private ITiposHabilidadeRepository _tiposHabilidadeRepository { get; set; }


        public TiposHabilidadesController()
        {

            _tiposHabilidadeRepository = new TiposHabilidadeRepository();

        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tiposHabilidadeRepository.ListarTiposHabilidade());
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_tiposHabilidadeRepository.BuscarPorId(id));  // status code 200
        }



        [HttpPost]
        public IActionResult Post(TiposHabilidade novoTipoHabilidade)
        {
            _tiposHabilidadeRepository.CadastrarTipoHabilidade(novoTipoHabilidade);

            return StatusCode(201);  // status code "created"
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, TiposHabilidade tipoHabilidadeAtualizada)
        {

            _tiposHabilidadeRepository.AtualizarTipoHabilidade(id, tipoHabilidadeAtualizada);

            return NoContent();  // status code 204

        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tiposHabilidadeRepository.DeletarTipoHabilidade(id);

            return StatusCode(204);
        }


        [HttpGet("habilidades")]
        public IActionResult GetTypesAbilities()
        {
            return Ok(_tiposHabilidadeRepository.ListarHabilidades());
        }


    }
}
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

    public class PersonagensController : ControllerBase
    {

        private IPersonagemRepository _personagemRepository { get; set; }


        public PersonagensController()
        {

            _personagemRepository = new PersonagemRepository();

        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personagemRepository.ListarPersonagens());
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_personagemRepository.BuscarPorId(id));  // status code 200
        }



        [HttpPost]
        public IActionResult Post(Personagem novoPersonagem)
        {
            _personagemRepository.CadastrarPersonagem(novoPersonagem);

            return StatusCode(201);  // status code "created"
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Personagem personagemAtualizado)
        {

            _personagemRepository.AtualizarPersonagem(id, personagemAtualizado);

            return NoContent();  // status code 204

        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personagemRepository.DeletarPersonagem(id);

            return StatusCode(204);
        }


        [HttpGet("classes")]
        public IActionResult GetCharacters()
        {
            return Ok(_personagemRepository.ListarClasses());
        }


    }

}

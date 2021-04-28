using Microsoft.AspNetCore.Authorization;
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

    
    public class ClassesController : ControllerBase
    {

        private IClasseRepository _classeRepository { get; set; }

        public ClassesController()
        {
            _classeRepository = new ClasseRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_classeRepository.ListarClasses());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_classeRepository.BuscarClassePorId(id));
        }

        
        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Post(Classe novaClasse)
        {
            _classeRepository.CadastrarClasse(novaClasse);

            return StatusCode(201);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Classe classeAtualizada)
        {
            _classeRepository.AtualizarClasseUrl(id, classeAtualizada);

            return StatusCode(204);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _classeRepository.DeletarClasse(id);

            return StatusCode(204);
        }


        [HttpGet("personagens")]
        public IActionResult GetCharacters()
        {
            return Ok(_classeRepository.ListarPersonagensInclusos());
        }


    }
}

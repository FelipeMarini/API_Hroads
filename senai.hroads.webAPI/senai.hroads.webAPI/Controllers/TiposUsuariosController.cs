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
    
    public class TiposUsuariosController : ControllerBase
    {

        private ITiposUsuarioRepository _tiposUsuarioRepository { get; set; }

        public TiposUsuariosController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tiposUsuarioRepository.ListarTiposUsuarios());
        }

        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_tiposUsuarioRepository.BuscarTipoUsuarioPorId(id));
        }

        
        
        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Post(TiposUsuario novoTipoUsuario)
        {
            _tiposUsuarioRepository.CadastrarTipoUsuario(novoTipoUsuario);

            return StatusCode(201);
        }

        
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, TiposUsuario tipoUsuarioAtualizado)
        {
            _tiposUsuarioRepository.AtualizarTipoUsuarioUrl(id, tipoUsuarioAtualizado);

            return StatusCode(204);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tiposUsuarioRepository.DeletarTipoUsuario(id);

            return StatusCode(204);
        }

        
        [HttpGet("usuarios")]
        public IActionResult GetUsers()
        {
           return Ok(_tiposUsuarioRepository.ListarUsuariosInclusos());
        }
    
    
    }
}

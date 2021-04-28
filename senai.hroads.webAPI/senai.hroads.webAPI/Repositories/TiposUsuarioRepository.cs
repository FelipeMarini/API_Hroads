using Microsoft.EntityFrameworkCore;
using senai.hroads.webAPI.Contexts;
using senai.hroads.webAPI.Domains;
using senai.hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {

        HroadsContext ctx = new HroadsContext();

        
        public void AtualizarTipoUsuarioUrl(int id, TiposUsuario tipoUsuarioAtualizado)
        {
            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);

            if (tipoUsuarioAtualizado.Titulo != null)
            {
                tipoUsuarioBuscado.Titulo = tipoUsuarioAtualizado.Titulo;
            }

            ctx.TiposUsuarios.Update(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        
        public TiposUsuario BuscarTipoUsuarioPorId(int id)
        {
            return ctx.TiposUsuarios.FirstOrDefault(t => t.IdTiposUsuario == id);
        }

        
        public void CadastrarTipoUsuario(TiposUsuario novoTipoUsuario)
        {
            ctx.TiposUsuarios.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        
        public void DeletarTipoUsuario(int id)
        {
            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);

            ctx.TiposUsuarios.Remove(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public List<TiposUsuario> ListarTiposUsuarios()
        {
            return ctx.TiposUsuarios.ToList();
        }

        
        public List<TiposUsuario> ListarUsuariosInclusos()
        {
            return ctx.TiposUsuarios.Include(t => t.Usuarios).ToList();
        }
    
    
    
    }
}

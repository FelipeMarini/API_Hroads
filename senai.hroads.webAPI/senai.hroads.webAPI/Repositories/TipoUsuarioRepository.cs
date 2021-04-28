using senai.hroads.webAPI.Contexts;
using senai.hroads.webAPI.Domains;
using senai.hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        HroadsContext ctx = new HroadsContext();


        public void AtualizarTipoUsuario(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            TipoUsuario tipoUsuarioBuscado =  
        }

        public TipoUsuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastrarTipoUsuario(TipoUsuario novoTipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void DeletarTipoUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuario> ListarTiposUsuarios()
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuario> ListarUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}

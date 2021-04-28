using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface ITipoUsuarioRepository
    {

        List<TipoUsuario> ListarTiposUsuarios();

        
        TipoUsuario BuscarPorId(int id);

        
        void CadastrarTipoUsuario(TipoUsuario novoTipoUsuario);


        void AtualizarTipoUsuario(int id, TipoUsuario tipoUsuarioAtualizado);


        void DeletarTipoUsuario(int id);


        List<TipoUsuario> ListarUsuarios();

    
    }
}

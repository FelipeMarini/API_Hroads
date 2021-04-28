using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface ITiposUsuarioRepository
    {
        List<TiposUsuario> ListarTiposUsuarios();

        TiposUsuario BuscarTipoUsuarioPorId(int id);

        void CadastrarTipoUsuario(TiposUsuario novoTipoUsuario);

        void AtualizarTipoUsuarioUrl(int id, TiposUsuario tipoUsuarioAtualizado);


        void DeletarTipoUsuario(int id);

        List<TiposUsuario> ListarUsuariosInclusos();
    }
}

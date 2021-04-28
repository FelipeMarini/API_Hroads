using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface IUsuarioRepository
    {

        Usuario BuscarPorEmailSenha(string email, string senha);

        List<Usuario> ListarUsuarios();

        Usuario BuscarUsuarioPorId(int id);

        void CadastrarUsuario(Usuario novoUsuario);

        void AtualizarUsuarioUrl(int id, Usuario usuarioAtualizado);

        void DeletarUsuario(int id);

        List<Usuario> ListarTiposUsuariosInclusos();

    }
}

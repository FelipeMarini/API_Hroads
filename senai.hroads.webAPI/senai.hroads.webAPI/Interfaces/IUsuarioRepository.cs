using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface IUsuarioRepository
    {

        List<Usuario> ListarUsuarios();

        
        Usuario BuscarPorId(int id);


        void CadastrarUsuario(Usuario novoUsuario);


        void AtualizarUsuario(int id, Usuario usuarioAtualizado);


        void DeletarUsuario(int id);


        List<Usuario> ListarTiposUsuarios();


    }
}

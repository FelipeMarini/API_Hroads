using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface IPersonagemRepository
    {

        List<Personagem> ListarPersonagens();

        Personagem BuscarPorId(int id);

        void CadastrarPersonagem(Personagem novoPersonagem);

        void AtualizarPersonagem(int id, Personagem personagemAtualizado);

        void DeletarPersonagem(int id);

        List<Personagem> ListarClasses();


    }
}

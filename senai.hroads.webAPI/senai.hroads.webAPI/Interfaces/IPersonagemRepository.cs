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

        Personagem BuscarPersonagemPorId(int id);

        void CadastrarPersonagem(Personagem novoPersonagem);

        void AtualizarPersonagemUrl(int id, Personagem personagemAtualizado);

        void DeletarPersonagem(int id);

        List<Personagem> ListarClassesInclusas();
    }
}

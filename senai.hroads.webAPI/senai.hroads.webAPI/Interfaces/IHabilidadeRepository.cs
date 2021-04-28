using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface IHabilidadeRepository
    {
        
        List<Habilidade> ListarHabilidades();


        Habilidade BuscarPorId(int id);


        void CadastrarHabilidade(Habilidade novaHabilidade);


        // atualiza habilidade passando o id pela url da requisição
        void AtualizarHabilidade(int id, Habilidade habilidadeAtualizada);


        void DeletarHabilidade(int id);


        /// <summary>
        /// Lista todas as habilidades e o tipo de habilidade de cada uma
        /// </summary>
        /// <returns>Uma lista de habilidades com o tipo de habilidade de cada uma da lista</returns>
        List<Habilidade> ListarTiposHabilidade();
    
    
    }
}

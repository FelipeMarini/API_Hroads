using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface IClasseRepository
    {

        List<Classe> ListarClasses();

        
        Classe BuscarPorId(int id);

        
        void CadastrarClasse(Classe novaClasse);

        
        // atualiza classe passando o id pela url da requisição
        void AtualizarClasse(int id, Classe classeAtualizada);

        
        void DeletarClasse(int id);

        
        /// <summary>
        /// Lista todas as classes com seus respectivos personagens
        /// </summary>
        /// <returns>Uma lista de classes com seus personagens</returns>
        List<Classe> ListarPersonagens();
    
    }

}

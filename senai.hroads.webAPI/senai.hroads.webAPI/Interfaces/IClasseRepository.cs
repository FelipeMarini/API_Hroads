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

        Classe BuscarClassePorId(int id);

        void CadastrarClasse(Classe novaClasse);

        void AtualizarClasseUrl(int id, Classe classeAtualizada);

        void DeletarClasse(int id);

        List<Classe> ListarPersonagensInclusos();
    }
}

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

        Habilidade BuscarHabilidadePorId(int id);

        void CadastrarHabilidade(Habilidade novaHabilidade);

        void AtualizarHabilidadeUrl(int id, Habilidade habilidadeAtualizada);

        void DeletarHabilidade(int id);

        List<Habilidade> ListarTiposHabilidadeInclusas();

    }
}

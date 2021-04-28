using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface ITiposHabilidadeRepository
    {

        List<TiposHabilidade> ListarTiposHabilidade();

        TiposHabilidade BuscarPorId(int id);

        void CadastrarTipoHabilidade(TiposHabilidade novoTipoHabilidade);

        void AtualizarTipoHabilidade(int id, TiposHabilidade tipoHabilidadeAtualizada);

        void DeletarTipoHabilidade(int id);

        List<TiposHabilidade> ListarHabilidades();


    }
}

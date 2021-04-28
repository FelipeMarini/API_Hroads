using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Interfaces
{
    interface ITiposHabilidadeRepository
    {
        List<TiposHabilidade> ListarTiposHabilidades();

        TiposHabilidade BuscarTipoHabilidadePorId(int id);

        void CadastrarTipoHabilidade(TiposHabilidade novoTipoHabilidade);

        void AtualizarTipoHabilidadeUrl(int id, TiposHabilidade tipoHabilidadeAtualizado);

        void DeletarTipoHabilidade(int id);

        List<TiposHabilidade> ListarHabilidadesInclusas();
    }
}

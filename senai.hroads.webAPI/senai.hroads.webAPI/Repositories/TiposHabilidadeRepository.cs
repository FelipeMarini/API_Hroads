using Microsoft.EntityFrameworkCore;
using senai.hroads.webAPI.Contexts;
using senai.hroads.webAPI.Domains;
using senai.hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Repositories
{
    public class TiposHabilidadeRepository : ITiposHabilidadeRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void AtualizarTipoHabilidadeUrl(int id, TiposHabilidade tipoHabilidadeAtualizado)
        {
            TiposHabilidade tipoHabilidadeBuscado = ctx.TiposHabilidades.Find(id);

            if (tipoHabilidadeAtualizado.TipoHabilidade != null)
            {
                tipoHabilidadeBuscado.TipoHabilidade = tipoHabilidadeAtualizado.TipoHabilidade;
            }

            ctx.TiposHabilidades.Update(tipoHabilidadeBuscado);

            ctx.SaveChanges();
        }

        public TiposHabilidade BuscarTipoHabilidadePorId(int id)
        {
            return ctx.TiposHabilidades.FirstOrDefault(t => t.IdTiposHabilidade == id);
        }

        public void CadastrarTipoHabilidade(TiposHabilidade novoTipoHabilidade)
        {
            ctx.TiposHabilidades.Add(novoTipoHabilidade);

            ctx.SaveChanges();
        }

        public void DeletarTipoHabilidade(int id)
        {
            TiposHabilidade tipoHabilidadeBuscado = ctx.TiposHabilidades.Find(id);

            ctx.TiposHabilidades.Remove(tipoHabilidadeBuscado);

            ctx.SaveChanges();
        }


        public List<TiposHabilidade> ListarTiposHabilidades()
        {
            return ctx.TiposHabilidades.ToList();
        }
        
        
        public List<TiposHabilidade> ListarHabilidadesInclusas()
        {
            return ctx.TiposHabilidades.Include(t => t.Habilidades).ToList();
        }
    
    
    }
}

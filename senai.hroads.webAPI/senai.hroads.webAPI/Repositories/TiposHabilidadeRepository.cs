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

        public void AtualizarTipoHabilidade(int id, TiposHabilidade tipoHabilidadeAtualizada)
        {
            TiposHabilidade tipoHabilidadeBuscada = ctx.TiposHabilidades.Find(id);

            if (tipoHabilidadeAtualizada.NomeTiposHabilidade != null)
            {
                tipoHabilidadeBuscada.NomeTiposHabilidade = tipoHabilidadeAtualizada.NomeTiposHabilidade;
            }

            ctx.TiposHabilidades.Update(tipoHabilidadeBuscada);

            ctx.SaveChanges();
        }

        
        
        public TiposHabilidade BuscarPorId(int id)
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
            TiposHabilidade tipoHabilidadeBuscada = ctx.TiposHabilidades.Find(id);

            ctx.TiposHabilidades.Remove(tipoHabilidadeBuscada);

            ctx.SaveChanges();
        }

        
        
        public List<TiposHabilidade> ListarHabilidades()
        {
            // retorna a lista de tipos de habilidade com o nome das habilidades de cada um dos tipos existentes
            return ctx.TiposHabilidades.Include(h => h.Habilidades).ToList();
        }

        
        
        public List<TiposHabilidade> ListarTiposHabilidade()
        {
            return ctx.TiposHabilidades.ToList();
        }
    
    
    }
}

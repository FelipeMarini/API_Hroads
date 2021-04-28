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
    public class HabilidadeRepository : IHabilidadeRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void AtualizarHabilidadeUrl(int id, Habilidade habilidadeAtualizada)
        {
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(id);

            if (habilidadeAtualizada.Nome != null)
            {
                habilidadeBuscada.Nome = habilidadeAtualizada.Nome;
            }

            ctx.Habilidades.Update(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public Habilidade BuscarHabilidadePorId(int id)
        {
            return ctx.Habilidades.FirstOrDefault(h => h.IdHabilidade == id);
        }

        public void CadastrarHabilidade(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Add(novaHabilidade);

            ctx.SaveChanges();
        }

        public void DeletarHabilidade(int id)
        {
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(id);

            ctx.Habilidades.Remove(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidade> ListarHabilidades()
        {
            return ctx.Habilidades.ToList();
        }

        public List<Habilidade> ListarTiposHabilidadeInclusas()
        {
            return ctx.Habilidades.Include(h => h.TiposHabilidades).ToList();
        }

        
    }
}

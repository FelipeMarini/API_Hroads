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
    public class ClasseRepository : IClasseRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void AtualizarClasseUrl(int id, Classe classeAtualizada)
        {
            Classe classeBuscada = ctx.Classes.Find(id);

            if (classeAtualizada.Nome != null)
            {
                classeBuscada.Nome = classeAtualizada.Nome;
            }

            ctx.Classes.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public Classe BuscarClassePorId(int id)
        {
            return ctx.Classes.FirstOrDefault(c => c.IdClasse == id);
        }

        public void CadastrarClasse(Classe novaClasse)
        {
            ctx.Classes.Add(novaClasse);

            ctx.SaveChanges();
        }

        public void DeletarClasse(int id)
        {
            Classe classeBuscada = ctx.Classes.Find(id);

            ctx.Classes.Remove(classeBuscada);

            ctx.SaveChanges();
        }

        public List<Classe> ListarClasses()
        {
            return ctx.Classes.ToList();
        }

        public List<Classe> ListarPersonagensInclusos()
        {
            return ctx.Classes.Include(c => c.Personagens).ToList();
        }
    
    
    }
}

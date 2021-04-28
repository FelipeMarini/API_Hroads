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
    public class PersonagemRepository : IPersonagemRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void AtualizarPersonagem(int id, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = ctx.Personagens.Find(id);

            if (personagemAtualizado.NomePersonagem != null)
            {
                personagemBuscado.NomePersonagem = personagemAtualizado.NomePersonagem;
            }

            ctx.Personagens.Update(personagemBuscado);

            ctx.SaveChanges();
        }

        
        
        public Personagem BuscarPorId(int id)
        {
            return ctx.Personagens.FirstOrDefault(p => p.IdPersonagem == id);
        }

        
        
        public void CadastrarPersonagem(Personagem novoPersonagem)
        {
            ctx.Personagens.Add(novoPersonagem);

            ctx.SaveChanges();
        }

        
        
        public void DeletarPersonagem(int id)
        {
            Personagem personagemBuscado = ctx.Personagens.Find(id);

            ctx.Personagens.Remove(personagemBuscado);

            ctx.SaveChanges();
        }

        
        
        public List<Personagem> ListarClasses()
        {
            // retorna a lista de personagens e as classes que cada personagem pertence
            return ctx.Personagens.Include(p => p.Classes).ToList();
        }

        
        
        public List<Personagem> ListarPersonagens()
        {
            return ctx.Personagens.ToList();
        }
    
    
    }

}

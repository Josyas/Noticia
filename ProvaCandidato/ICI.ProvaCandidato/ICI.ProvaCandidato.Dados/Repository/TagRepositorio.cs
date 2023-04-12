using ICI.ProvaCandidato.Dados.Data;
using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Dados.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository
{
    public class TagRepositorio : ITagRepositorio
    {
        private readonly AppDbContext _dbContext;

        public TagRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task IncluirTag(Tag tag)
        {
            _dbContext.Add(tag);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AlterarTag(Tag tag)
        {
            _dbContext.Entry(tag).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task ExcluirTag(Tag tag)
        {
            _dbContext.Remove(tag);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Tag>> ListaTag()
        {
            var listaTag = await _dbContext.Tags.AsNoTracking().ToListAsync();
            return listaTag;
        }

        public async Task<Tag> ListaTagId(int id)
        {
           var listaTag = await _dbContext.Tags.Where(x => x.Id == id).FirstOrDefaultAsync();
           return listaTag;
        }

        public async Task<List<Tag>> PesquisarTag(string buscaTag)
        {
           var localizarTag = await _dbContext.Tags.Where(x => EF.Functions.Like(x.Descricao, $"{buscaTag}")).ToListAsync();

            return localizarTag;
        }

        //passar esse metodo para noticia
        public async Task<bool> TagVinculada(int idNoticia)
        {
            var noticiaVinculada = await _dbContext.NoticiaTags.AnyAsync(x => x.IdTag == idNoticia);

            return noticiaVinculada;
        }
    }
}

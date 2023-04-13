using ICI.ProvaCandidato.Dados.Data;
using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Dados.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository
{
    public class NoticiaRepositorio : INoticiaRepositorio
    {
        private readonly AppDbContext _dbContext;

        public NoticiaRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task IncluirNoticia(Noticia noticia)
        {
            _dbContext.Add(noticia);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Noticia> AlterarNoticia(Noticia noticia)
        {
            _dbContext.Entry(noticia).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return noticia;
        }

        public async Task ExcluirNoticia(Noticia noticia)
        {
            _dbContext.Remove(noticia);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Noticia>> ListaNoticia()
        {
            var listaNoticia = await _dbContext.Noticias.AsNoTracking().OrderByDescending(x => x.Id).ToListAsync();

            return listaNoticia;
        }

        public async Task<Noticia> ListaNoticiaId(int id)
        {
            var listaNoticia = await _dbContext.Noticias.Where(x => x.Id == id).FirstOrDefaultAsync();

            return listaNoticia;
        }
    }
}

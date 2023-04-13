using ICI.ProvaCandidato.Dados.Data;
using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Dados.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly AppDbContext _dbContext;

        public UsuarioRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task IncluirUsuario(Usuario usuario)
        {
            _dbContext.Add(usuario);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Usuario> AlterarUsuario(Usuario usuario)
        {
            _dbContext.Entry(usuario).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task ExcluirUsuario(Usuario usuario)
        {
            _dbContext.Remove(usuario);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Usuario>> ListaUsuario()
        {
            var listaUsuario = await _dbContext.Usuarios.Include(x => x.Noticias).ToListAsync();

            return listaUsuario;
        }
    }
}

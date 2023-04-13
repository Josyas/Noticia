using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository.Interface
{
    public interface INoticiaRepositorio
    {
        Task IncluirNoticia(Noticia noticia);
        Task<Noticia> AlterarNoticia(Noticia noticia);
        Task ExcluirNoticia(Noticia noticia);
        Task<Noticia> ListaNoticiaId(int id);
        Task<List<Noticia>> ListaNoticia();
    }
}

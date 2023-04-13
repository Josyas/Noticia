using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service.Interface
{
    public interface INoticiaService
    {
        Task<Noticia> CadastrarNoticia(string titulo, string texto, int idTag, int idUsuario);
        Task<Noticia> EditarNoticia(Noticia noticia);
        Task ApagarNoticia(int id);
        Task<List<Noticia>> ListaNoticia();
    }
}

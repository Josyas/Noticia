using ICI.ProvaCandidato.Dados.Entities;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service.Interface
{
    public interface INoticiaService
    {
        Task<Noticia> CadastrarNoticia(string titulo, string texto, int idTag, int idUsuario);
    }
}

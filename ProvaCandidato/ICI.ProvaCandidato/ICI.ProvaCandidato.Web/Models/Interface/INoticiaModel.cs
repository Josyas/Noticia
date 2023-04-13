using ICI.ProvaCandidato.Dados.Entities;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models.Interface
{
    public interface INoticiaModel
    {
        Task<Noticia> CadastrarNoticia(string titulo, string texto, int idTag, int idUsuario);
    }
}

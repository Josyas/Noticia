using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using ICI.ProvaCandidato.Web.Models.Interface;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models
{
    public class NoticiaModel : INoticiaModel
    {
        private readonly INoticiaService _noticiaService;

        public NoticiaModel(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }
          
        public async Task<Noticia> CadastrarNoticia(string titulo, string texto,int idTag, int idUsuario)
        {
            var noticiaCadastro = await _noticiaService.CadastrarNoticia(titulo, texto, idTag, idUsuario);

            return noticiaCadastro;
        }
    }
}

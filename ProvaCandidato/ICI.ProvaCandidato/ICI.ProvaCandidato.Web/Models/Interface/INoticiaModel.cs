using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models.Interface
{
    public interface INoticiaModel
    {
        Task<Noticia> CadastrarNoticia(string titulo, string texto, int idTag, int idUsuario);
        Task<Noticia> EditarNoticia(NoticiaDTO noticiaDTO);
        Task ApagarNoticia(NoticiaDTO noticiaDTO);
        Task<List<Noticia>> ListaNoticia();
    }
}

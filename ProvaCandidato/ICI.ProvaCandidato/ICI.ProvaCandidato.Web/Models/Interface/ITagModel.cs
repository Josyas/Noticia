using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models.Interface
{
    public interface ITagModel
    {
        Task<Tag> CadastraTagNoticia(string descricao);
        Task<Tag> AlterarTag(TagDTO tagDTO);
        Task ApagarTagId(int id);
        Task<List<Tag>> ListaTag();
        Task<string> NaoPermitirNomeTagDuplicada(string descricao);
        Task<bool> TagVinculada(int idTag);
    }
}

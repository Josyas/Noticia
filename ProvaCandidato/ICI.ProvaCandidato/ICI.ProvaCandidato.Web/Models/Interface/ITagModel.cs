using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models.Interface
{
    public interface ITagModel
    {
        Task<Tag> CadastraTagNoticia(string descricao);
        Task<Tag> AlterarTag(int id);
        Task ApagarTagId(int id);
        Task<List<Tag>> ListaTag();
        Task PesquisarListaTag(string buscaTag);
        Task<string> NaoPermitirNomeTagDuplicada(string descricao);
    }
}

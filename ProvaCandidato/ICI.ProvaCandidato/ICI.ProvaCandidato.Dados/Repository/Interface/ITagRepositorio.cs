using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository.Interface
{
    public interface ITagRepositorio
    {
        Task IncluirTag(Tag tag);
        Task AlterarTag(Tag tag);
        Task ExcluirTag(Tag tag);
        Task<List<Tag>> ListaTag();
        Task<List<Tag>> PesquisarTag(string buscaTag);
        Task<Tag> ListaTagId(int id);
    }
}

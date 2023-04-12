using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository.Interface
{
    public interface ITagRepositorio
    {
        Task IncluirTag(Tag tag);
        Task<Tag> AlterarTag(Tag tag);
        Task ExcluirTag(Tag tag);
        Task<List<Tag>> ListaTag();
        Task<Tag> ListaTagId(int id);
        Task<bool> TagVinculada(int idNoticia);
    }
}

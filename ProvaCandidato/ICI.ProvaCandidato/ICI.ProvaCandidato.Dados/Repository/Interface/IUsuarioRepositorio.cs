using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository.Interface
{
    public interface IUsuarioRepositorio
    {
        Task IncluirUsuario(Usuario usuario);
        Task<Usuario> AlterarUsuario(Usuario usuario);
        Task ExcluirUsuario(Usuario usuario);
        Task<List<Usuario>> ListaUsuario();
    }
}

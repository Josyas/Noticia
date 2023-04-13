using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service.Interface
{
    public interface IUsuarioService
    {
        Task<Usuario> CadastrarUsuario(string nome, string senha, string email);
        Task<List<Usuario>> ListaUsuario();
    }
}

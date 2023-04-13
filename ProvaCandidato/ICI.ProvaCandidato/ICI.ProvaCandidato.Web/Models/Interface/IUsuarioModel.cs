using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models.Interface
{
    public interface IUsuarioModel
    {
        Task CadastraUsuario(string nome, string senha, string email);
        Task<List<Usuario>> ListaUsuario();
    }
}

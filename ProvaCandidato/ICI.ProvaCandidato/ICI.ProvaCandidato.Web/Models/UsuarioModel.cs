using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using ICI.ProvaCandidato.Web.Models.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models
{
    public class UsuarioModel : IUsuarioModel
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioModel(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task CadastraUsuario(string nome, string senha, string email)
        {
            await _usuarioService.CadastrarUsuario(nome, senha, email);
        }

        public async Task<List<Usuario>> ListaUsuario()
        {
            var listaUsuario = await _usuarioService.ListaUsuario();

            return listaUsuario;
        }
    }
}

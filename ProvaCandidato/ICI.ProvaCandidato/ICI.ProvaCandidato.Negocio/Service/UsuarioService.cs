using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Dados.Repository.Interface;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<Usuario> CadastrarUsuario(string nome, string senha, string email)
        {
            Usuario usuario = new() 
            { 
                Nome = nome,
                Senha = senha,
                Email = email
            };

            await _usuarioRepositorio.IncluirUsuario(usuario);

            return usuario;
        }

        public async Task<List<Usuario>> ListaUsuario()
        {
            var listaUsuario = await _usuarioRepositorio.ListaUsuario();

            return listaUsuario;
        }
    }
}

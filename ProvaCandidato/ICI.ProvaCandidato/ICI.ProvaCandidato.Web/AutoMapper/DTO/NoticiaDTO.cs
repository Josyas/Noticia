
using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;

namespace ICI.ProvaCandidato.Web.AutoMapper.DTO
{
    public class NoticiaDTO
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public int IdTag { get; set; }
        public int IdUsuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public int UsuarioSelecionadoId { get; set; }
    }
}

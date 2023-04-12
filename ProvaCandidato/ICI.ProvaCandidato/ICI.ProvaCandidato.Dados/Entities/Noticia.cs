using System.Collections.Generic;

namespace ICI.ProvaCandidato.Dados.Entities
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public List<NoticiaTag> NoticiaTags { get; set; }
    }
}

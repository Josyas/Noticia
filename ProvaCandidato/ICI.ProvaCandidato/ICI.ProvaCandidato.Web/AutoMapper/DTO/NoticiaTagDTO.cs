using ICI.ProvaCandidato.Dados.Entities;

namespace ICI.ProvaCandidato.Web.AutoMapper.DTO
{
    public class NoticiaTagDTO
    {
        public int Id { get; set; }

        public int IdTag { get; set; }
        public Tag Tag { get; set; }

        public int? IdNoticia { get; set; }
        public Noticia Noticia { get; set; }
    }
}

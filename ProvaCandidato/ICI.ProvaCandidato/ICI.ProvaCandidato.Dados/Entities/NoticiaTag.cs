namespace ICI.ProvaCandidato.Dados.Entities
{
    public class NoticiaTag
    {
        public int Id { get; set; }

        public int IdTag { get; set; }
        public Tag Tag { get; set; }

        public int IdNoticia { get; set; }
        public Noticia Noticia { get; set; }
    }
}

using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Dados.Repository.Interface;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service
{
    public class NoticiaService : INoticiaService
    {
        private readonly INoticiaRepositorio _noticiaRepositorio;

        public NoticiaService(INoticiaRepositorio noticiaRepositorio)
        {
            _noticiaRepositorio = noticiaRepositorio;
        }

        public async Task<Noticia> CadastrarNoticia(string titulo, string texto, int idTag, int idUsuario)
        {
            Noticia noticia = new()
            {
                Titulo= titulo,
                Texto= texto,
                IdUsuario = idUsuario,
                NoticiaTags = new List<NoticiaTag>
                {
                    new NoticiaTag
                    {
                        IdTag = idTag
                    }
                }
            };

            if (noticia == null)
                return noticia;

            await _noticiaRepositorio.IncluirNoticia(noticia);

            return noticia;
        }

        public async Task<Noticia> EditarNoticia(Noticia noticia)
        {
            if (noticia == null)
                return noticia;

            var alterarNoticia = await _noticiaRepositorio.AlterarNoticia(noticia);

            return alterarNoticia;
        }

        public async Task ApagarNoticia(int id)
        {
            var noticiaId = await _noticiaRepositorio.ListaNoticiaId(id);

            await _noticiaRepositorio.ExcluirNoticia(noticiaId);
        }

        public async Task<List<Noticia>> ListaNoticia()
        {
            var listaNoticia = await _noticiaRepositorio.ListaNoticia();

            return listaNoticia;
        }
    }
}

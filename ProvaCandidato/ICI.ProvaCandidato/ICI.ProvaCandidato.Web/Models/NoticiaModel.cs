using AutoMapper;
using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using ICI.ProvaCandidato.Web.Models.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models
{
    public class NoticiaModel : INoticiaModel
    {
        private readonly INoticiaService _noticiaService;
        private readonly IMapper _mapper;

        public NoticiaModel(INoticiaService noticiaService, IMapper mapper)
        {
            _noticiaService = noticiaService;
            _mapper = mapper;
        }
          
        public async Task<Noticia> CadastrarNoticia(string titulo, string texto,int idTag, int idUsuario)
        {
            var noticiaCadastro = await _noticiaService.CadastrarNoticia(titulo, texto, idTag, idUsuario);

            return noticiaCadastro;
        }

        public async Task<Noticia> EditarNoticia(NoticiaDTO noticia)
        {
            var tag = _mapper.Map<Noticia>(noticia);
            var editarNoticia = await _noticiaService.EditarNoticia(tag);

            return editarNoticia;
        }

        public async Task ApagarNoticia(NoticiaDTO noticiaDTO)
        {
            await _noticiaService.ApagarNoticia(noticiaDTO.Id);
        }

        public async Task<List<Noticia>> ListaNoticia()
        {
            var listaNoticia = await _noticiaService.ListaNoticia();

            return listaNoticia;
        }
    }
}

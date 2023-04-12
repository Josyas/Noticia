using AutoMapper;
using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using ICI.ProvaCandidato.Web.Models.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models
{
    public class TagModel : ITagModel
    {
        private readonly ITagService  _tagService;
        private readonly IMapper _mapper;

        public TagModel(ITagService tagService, IMapper mapper)
        {
            _tagService = tagService;
            _mapper = mapper;
        }

        public async Task<Tag> CadastraTagNoticia(string descricao)
        {
            var cadastarTag = await _tagService.CadastraTag(descricao);
            
            return cadastarTag;
        }

        public async Task<Tag> AlterarTag(TagDTO tagDTO)
        {
            var tag = _mapper.Map<Tag>(tagDTO);

            return await _tagService.EditarTag(tag);
        }

        public async Task ApagarTagId(int id)
        {
            await _tagService.ApagarTag(id);
        }

        public async Task<List<Tag>> ListaTag()
        {
            var listaTag = await _tagService.ListaTag();
            
            return listaTag;
        }

        public async Task<string> NaoPermitirNomeTagDuplicada(string descricao)
        {
            var listaTag = await _tagService.ListaTag();

            var validacaoNomeDuplicado = listaTag.Any(x => x.Descricao == descricao);

            if (validacaoNomeDuplicado)
                return null;

            return descricao;
        }

        public async Task<bool> TagVinculada(int idTag)
        {
            var tag = await _tagService.TagNoticiaVinculada(idTag);

            return tag;
        }
    }
}

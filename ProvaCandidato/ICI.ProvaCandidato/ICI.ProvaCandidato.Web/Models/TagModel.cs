using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using ICI.ProvaCandidato.Web.Models.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Models
{
    public class TagModel : ITagModel
    {
        private readonly ITagService  _tagService;

        public TagModel(ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<Tag> CadastraTagNoticia(string descricao)
        {
            var cadastarTag = await _tagService.CadastraTag(descricao);
            
            return cadastarTag;
        }

        public async Task<Tag> AlterarTag(int id)
        {
            var alterar = await _tagService.EditarTag(id);

            return alterar;
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

        public async Task PesquisarListaTag(string buscaTag)
        {
            await _tagService.PesquisaTag(buscaTag);
        }

        public async Task<string> NaoPermitirNomeTagDuplicada(string descricao)
        {
            var listaTag = await _tagService.ListaTag();

            var validacaoNomeDuplicado = listaTag.Any(x => x.Descricao == descricao);

            if (validacaoNomeDuplicado)
                return null;

            return descricao;
        }
    }
}

using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Dados.Repository.Interface;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service
{
    public class TagService : ITagService
    {
        private readonly ITagRepositorio _tagRepositorio;

        public TagService(ITagRepositorio tagRepositorio)
        {
            _tagRepositorio = tagRepositorio;
        }

        public async Task<Tag> CadastraTag(string descricao)
        {
            Tag tag = new()
            {
               Descricao = descricao
            };

            await _tagRepositorio.IncluirTag(tag);

            return tag;
        }

        public async Task<Tag> EditarTag(int id)
        {
            var alterarTag = await _tagRepositorio.ListaTagId(id);

            await _tagRepositorio.AlterarTag(alterarTag);

            return alterarTag;
        }

        public async Task ApagarTag(int id)
        {
            var apagarTag = await _tagRepositorio.ListaTagId(id);

            await _tagRepositorio.ExcluirTag(apagarTag);
        }

        public async Task<List<Tag>> ListaTag()
        {
            var listaTags = await _tagRepositorio.ListaTag();

            return listaTags;
        }

        public async Task<List<Tag>> PesquisaTag(string buscaTag)
        {
            var localizarTag = await _tagRepositorio.PesquisarTag(buscaTag);

            return localizarTag;
        }
    }
}

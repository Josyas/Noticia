using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using ICI.ProvaCandidato.Web.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagModel _tagModel;

        public TagController(ITagModel tagModel)
        {
            _tagModel = tagModel;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastraTag(TagDTO tagDTO)
        {
            var tagDescricao = await _tagModel.NaoPermitirNomeTagDuplicada(tagDTO.Descricao);

            if (tagDescricao != null)
            {
                await _tagModel.CadastraTagNoticia(tagDTO.Descricao);

                TempData["Mensagem"] = "Tag cadastrada com sucesso!";

                return RedirectToAction("ListaTags");
            }

            TempData["AlertMessage"] = "nome da tag já está em uso.";

            return RedirectPermanent("https://localhost:44340/Tag");
        }

        public async Task<ActionResult> ApagarTag(int id)
        {
            var tagVinculada = await ValidacaoTagVinculada(id);

            if(tagVinculada == false)
            {
                await _tagModel.ApagarTagId(id);

                TempData["AlertMessage"] = "Tag apagado com sucesso.";
            }

            TempData["AlertMessage"] = "Tag está vinculada a uma notícia.";

            return Redirect("https://localhost:44340/Tag/ListaTags");
        }

        [HttpPost]
        public async Task<ActionResult> EditarTag(TagDTO tag)
        {
            if (ModelState.IsValid)
            {
                await _tagModel.AlterarTag(tag);

                TempData["AlertMessage"] = "Tag atualizada com sucesso!";

                return RedirectToAction("ListaTags");
            }
            else
            {
                return View("EditarTag", tag);
            }
        }

        public async Task<IActionResult> ListaTags()
        {
            var listaTag = await _tagModel.ListaTag();
            var listaTagDTO = listaTag.Select(tag => new TagDTO
            {
                Id = tag.Id,
                Descricao = tag.Descricao
            }).ToList();

            return View(listaTagDTO);
        }

        public async Task<bool> ValidacaoTagVinculada(int idTag)
        {
            var tag = await _tagModel.TagVinculada(idTag);

            return tag;
        }
    }
}

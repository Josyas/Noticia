using ICI.ProvaCandidato.Web.Models.DTO;
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
            await _tagModel.ApagarTagId(id);

            TempData["AlertMessage"] = "Tag apagado com sucesso.";

            return Redirect("https://localhost:44340/Tag/ListaTags");
        }

        public async Task<ActionResult> EditarTag(int id)
        {
            var alterarTag = await _tagModel.AlterarTag(id);

            TempData["AlertMessage"] = "Tag atualizada com sucesso!";

            return View(alterarTag);
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

        public async Task<IActionResult> PesquisarTagNoticia(TagDTO tagDTO)
        {
            if (ModelState.IsValid)
            {
                await _tagModel.PesquisarListaTag(tagDTO.Descricao);
                return Ok();
            }

            return NotFound("tag não encontrada.");
        }
    }
}

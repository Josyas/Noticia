using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using ICI.ProvaCandidato.Web.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaModel _noticiaModel;
        private readonly IUsuarioModel _usuarioModel;
        private readonly ITagModel _tagModel;

        public NoticiaController(INoticiaModel noticiaModel, IUsuarioModel usuarioModel, ITagModel tagModel)
        {
            _noticiaModel = noticiaModel;
            _usuarioModel = usuarioModel;
            _tagModel = tagModel;
        }

        public async Task<IActionResult> Index()
        {
            var listaUsuarios = await _usuarioModel.ListaUsuario();
            var listaTags = await _tagModel.ListaTag();
            var viewModel = new NoticiaDTO
            {
                Usuarios = listaUsuarios,
                UsuarioSelecionadoId = 0,
                Tags = listaTags,
                TagSelecionadoId = 0
            };
        
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarNoticia(NoticiaDTO noticiaDTO)
        {
            if (ModelState.IsValid)
            {
                await _noticiaModel.CadastrarNoticia(noticiaDTO.Titulo, noticiaDTO.Texto, noticiaDTO.TagSelecionadoId, noticiaDTO.UsuarioSelecionadoId);

                TempData["AlertMessage"] = "Tag cadastrada com sucesso!";

                return RedirectToAction("ListaNoticia");
            }
            
            return RedirectToAction("ListaNoticia");
        }

        public async Task<IActionResult> ListaNoticia()
        {
            var listaNoticia = await _noticiaModel.ListaNoticia();

            var listaNoticiaDTO = listaNoticia.Select(dto => new NoticiaDTO
            {
                Id = dto.Id,
                Titulo = dto.Titulo,
                Texto = dto.Texto,
                IdUsuario = dto.IdUsuario 

            }).ToList();

            return View(listaNoticiaDTO);
        }

        public async Task<ActionResult> EditarNoticia(NoticiaDTO noticiaDTO)
        {
            if (ModelState.IsValid)
            {
                await _noticiaModel.EditarNoticia(noticiaDTO);

                TempData["AlertMessage"] = "Tag atualizada com sucesso!";

                return RedirectToAction("ListaTags");
            }
            else
            {
                return View("EditarNoticia", noticiaDTO);
            }
        }

        public async Task<ActionResult> ApagarNoticia(NoticiaDTO noticiaDTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["AlertMessage"] = "Notícia não encontrada.";

                return RedirectToAction("ListaNoticia");
            }

            await _noticiaModel.ApagarNoticia(noticiaDTO);

            TempData["AlertMessage"] = "Notícia apagada com sucesso.";

            return RedirectToAction("ListaNoticia");
        }
    }
}

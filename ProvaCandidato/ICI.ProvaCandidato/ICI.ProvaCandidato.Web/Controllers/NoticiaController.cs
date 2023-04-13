using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using ICI.ProvaCandidato.Web.Models.Interface;
using Microsoft.AspNetCore.Mvc;
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
            await _noticiaModel.CadastrarNoticia(noticiaDTO.Titulo, noticiaDTO.Texto, noticiaDTO.TagSelecionadoId, noticiaDTO.UsuarioSelecionadoId);

            TempData["AlertMessage"] = "Tag cadastrada com sucesso!";

            return RedirectPermanent("https://localhost:44340/Noticia");
        }
    }
}

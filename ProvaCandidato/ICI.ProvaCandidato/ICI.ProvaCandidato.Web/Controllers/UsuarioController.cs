using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using ICI.ProvaCandidato.Web.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioModel _usuarioModel;

        public UsuarioController(IUsuarioModel usuarioModel)
        {
            _usuarioModel = usuarioModel;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> CadastrarUsuario(UsuarioDTO usuarioDTO)
        {
            if (ModelState.IsValid)
            {
                await _usuarioModel.CadastraUsuario(usuarioDTO.Nome, usuarioDTO.Email, usuarioDTO.Senha);

                TempData["AlertMessage"] = "Tag cadastrada com sucesso.";

                return RedirectPermanent("https://localhost:44340/Usuario");
            }

            TempData["AlertMessage"] = "Erro ao cadastradar usuario.";

            return RedirectPermanent("https://localhost:44340/Usuario");
        }
    }
}

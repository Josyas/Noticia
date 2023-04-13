using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Negocio.Service;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using ICI.ProvaCandidato.Web.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaModel _noticiaModel;
        private readonly IUsuarioModel _usuarioModel;

        public NoticiaController(INoticiaModel noticiaModel, IUsuarioModel usuarioModel)
        {
            _noticiaModel = noticiaModel;
            _usuarioModel = usuarioModel;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _usuarioModel.ListaUsuario();
            var viewModel = new NoticiaDTO
            {
                Usuarios = lista,
                UsuarioSelecionadoId = 0 
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarNoticia(NoticiaDTO noticiaDTO)
        {
            await _noticiaModel.CadastrarNoticia(noticiaDTO.Titulo, noticiaDTO.Texto, noticiaDTO.IdTag, noticiaDTO.UsuarioSelecionadoId);

            TempData["Mensagem"] = "Tag cadastrada com sucesso!";

            return RedirectPermanent("https://localhost:44340/Noticia");
        }
    }
}

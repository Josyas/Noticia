﻿using ICI.ProvaCandidato.Dados.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service.Interface
{
    public interface ITagService
    {
        Task<Tag> CadastraTag(string descricao);
        Task<Tag> EditarTag(Tag tag);
        Task ApagarTag(int id);
        Task<List<Tag>> ListaTag();
        Task<bool> TagNoticiaVinculada(int idTag);
    }
}

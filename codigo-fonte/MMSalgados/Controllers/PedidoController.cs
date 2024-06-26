﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MMSalgados.Domain.Entities;
using MMSalgados.Domain.Interfaces;
using MMSalgados.Utils.Attributes;
using MMSalgados.Utils.Extensions;
using MMSalgados.WebUI.Tipo;
using MMSalgados.WebUI.ViewModels.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMSalgados.WebUI.Controllers
{
    public class PedidoController : BaseController
    {
        private readonly IRepository<Pedido> _pedidoRepository;
        private readonly IRepository<ProdutoEntity> _produtoRepository;
        private readonly IMapper _imapper;

        public PedidoController(
            IRepository<Pedido> pedidoRepository,
            IRepository<ProdutoEntity> produtoRepository,
            IMapper imapper)
        {
            this._pedidoRepository = pedidoRepository;
            this._produtoRepository = produtoRepository;
            this._imapper = imapper;
        }

        [HttpGet, Authorize, SessionExpire]
        public async Task<IActionResult> Index()
        {
            var isAdmin = User.IsInRole("ADMIN");

            IQueryable<Pedido> query = _pedidoRepository.Table
                .Include(p => p.ItemPedido)
                .ThenInclude(p => p.Produto)
                .Where(pedido => pedido.Status == TipoPedidoStatus._FINALIZADO);

            if (!isAdmin)
            {
                query = query.Where(pedido => pedido.UsuarioId == HttpContext.Session.Get<int>("UserId"));
            }

            var pedidos = await query.ToListAsync();

            pedidos ??= new List<Pedido>();

            var model = pedidos.Select(pedido =>
                new IndexViewModel
                {
                    Id = pedido.Id,
                    Total = pedido.Total,
                    QuantidadeItens = pedido.QuantidadeItens,
                    Produtos = pedido.ItemPedido != null && pedido.ItemPedido.Any() ?
                    pedido.ItemPedido.Select(itempedido => _imapper.Map<ViewModels.Vitrine.DetailsViewModel>(itempedido.Produto)).ToList() :
                    new List<ViewModels.Vitrine.DetailsViewModel>()
                }
            ).ToList();

            return View(model);
        }

        [HttpPost, Authorize, SessionExpire]
        public async Task<IActionResult> Finalizar(FinalizarViewModel finalizarViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var pedido = await _pedidoRepository.Table
                        .Include(p => p.ItemPedido)
                        .ThenInclude(p => p.Produto)
                        .Where(pedido => pedido.Status == TipoPedidoStatus._NAO_FINALIZADO && pedido.UsuarioId == HttpContext.Session.Get<int>("UserId"))
                        .SingleOrDefaultAsync();

                    pedido.Status = TipoPedidoStatus._FINALIZADO;

                   /* foreach (var itemPedido in pedido?.ItemPedido ?? Enumerable.Empty<ItemPedido>())
                    {
                        // Seta o status do produto para inativo para que nao seja visualizado na vitrine
                        var produto = await _produtoRepository.FindById(itemPedido.ProdutoId);
                        produto.Ativo = false;

                        await _produtoRepository.Update(produto);
                        await _produtoRepository.CommitAsync();
                    }*/

                    await _pedidoRepository.Update(pedido);
                    await _pedidoRepository.CommitAsync();

                    AddSuccess("Pedido finalizado com sucesso!");
                }
                catch (Exception ex)
                {
                    TratarException(ex);
                }
                return RedirectToAction("Index", "Pedido");
            }
            AddError("Dados de pagamentos inválidos!");
            return RedirectToAction("Index", "Carrinho");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MMSalgados.WebUI.Controllers;
using Microsoft.AspNetCore.Http;
using MMSalgados.Domain.Entities;
using MMSalgados.Domain.Interfaces;
using MMSalgados.WebUI.ViewModels.Home;
using System.Threading.Tasks;
using System.Linq;
using MMSalgados.Utils.Extensions;
using Microsoft.EntityFrameworkCore;
using MMSalgados.WebUI.Tipo;
using Microsoft.AspNetCore.Authorization;

namespace MMSalgados.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IRepository<ProdutoEntity> _produtoRepository;
        private readonly IRepository<Pedido> _pedidoRepository;

        public HomeController(
            IRepository<ProdutoEntity> produtoRepository,
            IRepository<Pedido> pedidoRepository)
        {
            this._produtoRepository = produtoRepository;
            this._pedidoRepository = pedidoRepository;
        }

        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> Index()
        {
            var entity = await _produtoRepository.Table.Where(produto =>
                produto.UsuarioId == HttpContext.Session.Get<int>("UserId")
            ).ToListAsync();

            var produtosVendidos = entity?.Where(produto => produto.Ativo == false);

            var model = new IndexViewModel()
            {
                LucroMensal = produtosVendidos?.Sum(produto => produto.Preco),
                LucroAnual = produtosVendidos?.Sum(produto => produto.Preco),
                PorcentagemProdutosVendidos = entity?.Count > 0 ? (int)(decimal.Divide(produtosVendidos.Count(), entity.Count) * 100) : 0,
                QuantidadeProdutosCadastrados = entity?.Count
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return RedirectToAction("Index", "Vitrine");
        }
    }
}

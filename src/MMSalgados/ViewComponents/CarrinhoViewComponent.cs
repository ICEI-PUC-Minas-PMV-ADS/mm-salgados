using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MMSalgados.Domain.Entities;
using MMSalgados.Domain.Interfaces;
using MMSalgados.Utils.Extensions;
using MMSalgados.WebUI.Tipo;
using System.Linq;
using System.Threading.Tasks;

namespace MMSalgados.WebUI.ViewComponents
{
    [ViewComponent(Name = "carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public readonly IRepository<Pedido> _pedidoRepository;

        public CarrinhoViewComponent(IRepository<Pedido> pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pedido = await _pedidoRepository.Table
                    .Where(pedido => pedido.Status == TipoPedidoStatus._NAO_FINALIZADO && pedido.UsuarioId == HttpContext.Session.Get<int>("UserId"))
                    .SingleOrDefaultAsync();

            return View(pedido != null ? pedido.QuantidadeItens : 0);
        }
    }
}

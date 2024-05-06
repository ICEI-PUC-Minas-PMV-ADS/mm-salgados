using MMSalgados.WebUI.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMSalgados.WebUI.ViewModels.Home
{
    public class IndexViewModel : BaseViewModel
    {
        public decimal? LucroMensal { get; set; }
        public decimal? LucroAnual { get; set; }
        public int? PorcentagemProdutosVendidos { get; set; }
        public int? QuantidadeProdutosCadastrados { get; set; }
    }
}

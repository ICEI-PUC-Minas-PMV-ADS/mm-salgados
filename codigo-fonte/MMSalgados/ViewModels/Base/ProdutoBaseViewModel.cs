using Npgsql.TypeHandlers.NumericHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MMSalgados.WebUI.ViewModels.Base
{
    public class ProdutoBaseViewModel : BaseViewModel
    {
        [Required]
        public decimal? Preco { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Produto { get; set; }
        [Required]
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public string Modelo { get; set; }
    }
}

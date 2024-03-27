using MMSalgados.WebUI.ViewModels.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MMSalgados.WebUI.ViewModels.Vitrine
{
    public class IndexViewModel : BaseViewModel
    {
        public string Modelo { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }
        public string Image { get; set; }
    }
}
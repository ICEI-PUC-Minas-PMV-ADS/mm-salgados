using MMSalgados.WebUI.ViewModels.Base;
using System.ComponentModel.DataAnnotations;

namespace MMSalgados.WebUI.ViewModels.Account
{
    public class ForgotPasswordViewModel : BaseViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}

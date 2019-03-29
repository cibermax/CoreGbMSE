using System.ComponentModel.DataAnnotations;

namespace CoreGbMSE.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

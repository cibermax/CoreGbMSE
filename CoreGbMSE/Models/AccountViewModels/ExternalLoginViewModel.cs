using System.ComponentModel.DataAnnotations;

namespace CoreGbMSE.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

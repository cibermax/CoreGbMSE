using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreGbMSE.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }

        [Display(Name = "Организация")]
        [Required(ErrorMessage = "Организация, Обязательное поле")]
        public string OrgName { get; set; }

        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "ФИО, Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Телефон, Обязательное поле")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Сайт")]
        [DataType(DataType.Url)]
        public string WebUrl { get; set; }


    }
}

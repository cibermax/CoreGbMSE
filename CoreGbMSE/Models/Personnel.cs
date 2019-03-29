using CoreGbMSE.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreGbMSE.Models
{
    public class Personnel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonnelId { get; set; }

        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "ФИО, Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Должность, Обязательное поле")]
        public string Doljnost { get; set; }

        [Display(Name = "Отдел")]
        public Otdel Otdel { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Телефон, Обязательное поле")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}

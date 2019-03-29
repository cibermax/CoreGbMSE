using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreGbMSE.Data
{
    public class Filial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilialId { get; set; }

        [Display(Name = "Филиал")]
        [Required(ErrorMessage = "Филиал, Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Адрес, Обязательное поле")]
        public string Adress { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Телефон, Обязательное поле")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
    }
}
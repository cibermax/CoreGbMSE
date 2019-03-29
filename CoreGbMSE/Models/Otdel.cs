using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreGbMSE.Data
{
    public class Otdel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OtdelId { get; set; }

        [Display(Name = "Отдел")]
        [Required(ErrorMessage = "Отдел, Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Телефон, Обязательное поле")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
    }
}
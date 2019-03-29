using CoreGbMSE.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreGbMSE.Models
{
    public class TaskWork
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "ФИО, Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Отдел")]
        public virtual Otdel Otdel { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Телефон, Обязательное поле")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Display(Name = "Заявка")]
        [Required(ErrorMessage = "Заявка, Обязательное поле")]
        [DataType(DataType.MultilineText)]
        [MaxLength(5000)]
        public string Zayavka { get; set; }

    }
}

using CoreGbMSE.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace CoreGbMSE.Models
{
    public class TaskWork
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskWorkId { get; set; }

        [Display(Name = "Создана")]
        public DateTime DateAdd { get; set; }
        
        [Display(Name ="Тип Заявки")]
        [Required(ErrorMessage = "ФИО, Обязательное поле")]
        public virtual TaskType TaskType { get; set; }

        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "ФИО, Обязательное поле")]
        public string FullName { get; set; }

        [Display(Name = "Отдел")]
        public Otdel Otdel { get; set; }
        
        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Телефон, Обязательное поле")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Display(Name = "Текст заявки")]
        [Required(ErrorMessage = "Текст заявки, Обязательное поле")]
        [DataType(DataType.MultilineText)]
        [MaxLength(5000)]
        public string Zayavka { get; set; }

        [Display(Name ="Срочно")]
        public bool Srochno { get; set; }


        //[Display(Name = "Картинка ошибки")]
        //public string Image { get; set; }


        [Display(Name ="Статус")]
        public Status Status { get; set; }

    }

    public enum Status
    {

        [Display(Name = "Новая")]
        New,
        [Display(Name = "В работе")]
        Working,
        [Display(Name = "Выполнена")]
        Finish,
        [Display(Name = "Отменена")]
        Cancel,

    }
}

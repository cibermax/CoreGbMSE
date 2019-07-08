using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGbMSE.Models
{
    public class TaskType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskTypeId { get; set; }

        [Display(Name = "Тип Заявки")]
        [Required(ErrorMessage = "Тип Заявки, Обязательное поле")]
        public string Name { get; set; }

        public bool Srochno { get; set; }
    }
}

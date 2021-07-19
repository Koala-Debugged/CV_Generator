using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV_Generator.Presentation.Models
{
    public class InfoDTOModel
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Es necesario que introduzca su nombre.")]
        public string Nombre { get; set; }
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Es necesario que introduzca su apellido.")]
        public string Apellidos { get; set; }
        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "Es necesario que introduzca para qué empresa trabaja")]
        public string Empresa { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage ="Es necesario que introduzca su correo electrónico.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Librery_Str.Models
{
    public class Account
    {
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo Usuario es requerido.")]
        public string User { get; set; }
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "El campo Contraseña es requerido.")]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Librery_Str.Models
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(64, MinimumLength = 3,
        ErrorMessage = "64 maximo caracteres permitido y 3 minimo caracteres permitido.")]
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [StringLength(64, MinimumLength = 3,
        ErrorMessage = "64 maximo caracteres permitido y 3 minimo caracteres permitido.")]
        [Required(ErrorMessage = "El campo Usuario es requerido.")]
        [Display(Name = "Usuario")]
        public string User { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es requerido.")]
        [Display(Name = "Contraseña")]
        [StringLength(128, MinimumLength = 8,
        ErrorMessage = "128 maximo caracteres permitido y 8 minimo caracteres permitido.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(64, MinimumLength = 3,
        ErrorMessage = "64 maximo caracteres permitido y 3 minimo caracteres permitido.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Fecha inicio")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

    }
}
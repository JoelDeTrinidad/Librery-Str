using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Librery_Str.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(150, MinimumLength = 3, 
        ErrorMessage = "150 maximo caracteres permitido y 3 minimo caracteres permitido.")]
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "El campo Precio es requerido.")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "El campo Cantidad es requerido.")]
        [Display(Name = "Cantidad")]
        public int Stock { get; set; }
        [StringLength(200, MinimumLength = 3,
        ErrorMessage = "200 maximo caracteres permitido y 3 minimo caracteres permitido.")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [StringLength(60, MinimumLength = 3, 
        ErrorMessage = "60 maximo caracteres permitido y 3 minimo caracteres permitido.")]
        [Required(ErrorMessage = "El campo Marca es requerido.")]
        [Display(Name = "Marca")]
        public string Brand { get; set; }
        [Display(Name = "Fecha inicio")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

    }
}
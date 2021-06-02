using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escarolin_P1_APL2.Models
{
    public class Productos

    {
        [Key]
        [Required(ErrorMessage = "El campo esta vacio'ProductoId'")]
        [Range(0, 100, ErrorMessage = "El campo 'ProductoId' no puede ser 0 o (mayor a 1000).")]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Agregar una descripcion 'Decripcion'")]
        [MinLength(4, ErrorMessage = "El Campo 'Descripcion' debe tener por lo menos (4 caracteres).")]
        [RegularExpression(@"\S(.*)\S", ErrorMessage = "Debe ser un texto.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo esta vacio agregar una existencia 'Existencia'")]
        public decimal Existencia { get; set; }

        [Required(ErrorMessage = "No puede  de estar Vacío el campo 'Costo'")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "No puede de estar Vacío el campo 'ValorInventario'")]
        public decimal ValorInventario { get; set; }

    }
}

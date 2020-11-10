using System.ComponentModel.DataAnnotations;

namespace Formulario.Models
{
    public class Producto
    {
        [Required]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        
        [Required]
        public int Precio { get; set; }

        [Required]
        [Display(Name="Descripcion")]
        public string Descripcion { get; set; }

     
    }
}
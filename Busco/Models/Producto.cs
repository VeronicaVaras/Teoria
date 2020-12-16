using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Busco.Models
{
    [Table("t_producto")] 
    public class Producto
    {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name="Identificador")] 
    [Column("id")]
    public int id  { get; set; }
    
    [Display(Name="Nombre")] 
    [Column("nombre")]
    public string nombre { get; set; }
    
    [Display(Name="imagen")]
    [Column("imagen")]
    public string imagen { get; set; }
    
    [Required(ErrorMessage="Ingresar descripcion del producto")]
    [Display(Name="Descripcion del producto")] 
    [Column("descripcion")]
    public string descripcion { get; set; }
    
    [Required(ErrorMessage="Ingresar precio")]
    [Display(Name="Precio del producto")] 
    [Column("precio")]
    public double precio { get; set; }

    [Required(ErrorMessage="Ingresar celular de contacto")]
    [Display(Name="Celular de contacto")] 
    [Column("celular")]
    public int celular { get; set; }

    [Display(Name="Lugar de compra")] 
    [Column("lugar")]
    public string lugar { get; set; } 
    
    [Display(Name="Usuario")] 
    [Column("usuario")]
    public string usuario { get; set; }

    [NotMapped]
    public String Response { get; set; }

    }
}
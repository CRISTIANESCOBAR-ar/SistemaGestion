using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEntities;

public class Producto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Descripción es requerido.")]
    [MaxLength(250, ErrorMessage = "La Descripción no puede tener más de 50 caracteres.")]
    [MinLength(5, ErrorMessage = "La Descripción debe tener al menos 5 caracteres.")]
    [Display(Name = "Descripción")]
    public string Descripcion { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Precio de Compra es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Precio de Compra debe ser mayor o igual a 0.")]
    [Display(Name = "Precio de Compra")]
    public double Costo { get; set; }

    [Required(ErrorMessage = "El campo Precio de Venta es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Precio de Venta debe ser mayor o igual a 0.")]
    [Display(Name = "Precio de Venta")]
    public double PrecioVenta { get; set; }

    [Required(ErrorMessage = "El campo Stock es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Stock debe ser mayor o igual a 0.")]
    public double Stock { get; set; }

    [Required(ErrorMessage = "El campo IdUsuario es requerido.")]
    [Range(0, int.MaxValue, ErrorMessage = "El IdUsuario debe ser mayor o igual a 0.")]
    [Display(Name = "Id Usuario")]
    public int IdUsuario { get; set; }

}

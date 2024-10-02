using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEntities;

public class ProductoVendido
{
    // [Key]
    public int Id { get; set; }
    public int IdProducto { get; set; }

    // [Required(ErrorMessage = "El campo Stock es requerido.")]
    // [Range(0, double.MaxValue, ErrorMessage = "El Stock debe ser mayor o igual a 0.")]
    public double Stock { get; set; }
    public int IdVenta { get; set; }
}

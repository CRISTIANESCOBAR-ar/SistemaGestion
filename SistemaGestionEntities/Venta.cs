using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEntities;

public class Venta
{
    [Key]
    public int Id { get; set; }
    public string? Comentarios { get; set; }
    public int IdUsuario { get; set; }

}

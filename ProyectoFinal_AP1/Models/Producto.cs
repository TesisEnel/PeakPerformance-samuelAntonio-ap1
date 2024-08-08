using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Producto
{
    [Key]
    public int IdProducto { get; set; }

    [Required(ErrorMessage = "El campo Descripcion es obligatorio.")]
    public string Descripcion { get; set; }
    [Required(ErrorMessage = "El campo Stock es obligatorio.")]
    public int Stock { get; set; }
    [Required(ErrorMessage = "El campo Precio es obligatorio.")]
    public int Precio { get; set; }

    public byte[] Foto { get; set; }

}

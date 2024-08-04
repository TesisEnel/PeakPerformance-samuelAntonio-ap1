using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Producto
{
    [Key]
    public int IdProducto { get; set; }

    public string Descripcion { get; set; }

    public int Stock { get; set; }

    public int Precio { get; set; }

    public byte[] Foto { get; set; }

}

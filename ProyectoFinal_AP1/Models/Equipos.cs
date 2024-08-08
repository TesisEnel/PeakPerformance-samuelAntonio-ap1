using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Equipos
{
    [Key]
    public int IdEquipo { get; set; }
    [Required(ErrorMessage = "El campo descripcion es obligatorio.")]
    public string Descripcion { get; set; }
    [Required(ErrorMessage = "El campo tipo es obligatorio.")]
    public string Tipo { get; set; }
    public byte[] Foto { get; set; }
}

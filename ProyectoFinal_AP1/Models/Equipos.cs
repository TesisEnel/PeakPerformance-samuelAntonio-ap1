using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Equipos
{
    [Key]
    public int IdEquipo { get; set; }

    public string Descripcion { get; set; }
    
    public string Tipo { get; set; }
    public byte[] Foto { get; set; }
}

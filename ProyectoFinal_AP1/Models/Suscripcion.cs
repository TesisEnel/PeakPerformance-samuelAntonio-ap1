using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Suscripcion
{
    [Key]
    public int IdSuscripcion { get; set; }
    public string Descripcion { get; set; }
    public int Precio { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    public int? IdEntrenador { get; set; }
    public Entrenador Entrenador { get; set; }
    public byte[] FotoPerfil { get; set; }

    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

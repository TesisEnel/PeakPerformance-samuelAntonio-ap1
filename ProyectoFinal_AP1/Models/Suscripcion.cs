using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Suscripcion
{
    [Key]
    public int IdSuscripcion { get; set; }
    [Required(ErrorMessage = "La descripcion es obligatoria.")]
    [StringLength(50, ErrorMessage = "La descripcion no puede exceder los 50 caracteres.")]
    public string Descripcion { get; set; }

    [Required(ErrorMessage = "El campo precio es obligatorio.")]
    public int Precio { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    public int? IdEntrenador { get; set; }
    public Entrenador Entrenador { get; set; }
    public byte[] FotoPerfil { get; set; }

    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

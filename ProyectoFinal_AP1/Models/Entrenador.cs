using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Entrenador
{
    [Key]
    public int IdEntrenador { get; set; }
    [Required(ErrorMessage = "El campo nombre es obligatorio.")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El campo nivel es obligatorio.")]
    public string Nivel { get; set; }
    public string Genero { get; set; }
    public byte[] FotoPerfil { get; set; }

    public ICollection<Suscripcion> Suscripciones { get; set; } = new List<Suscripcion>();
    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

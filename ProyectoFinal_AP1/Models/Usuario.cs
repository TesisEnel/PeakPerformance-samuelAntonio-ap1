
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
    public string Apellido { get; set; }
    public string? Genero { get; set; }
    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo no es una dirección de email válida.")]
    public string Correo { get; set; }
    [Required(ErrorMessage = "La clave es obligatoria.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "La clave debe tener entre 6 y 100 caracteres.")]
    public string Clave { get; set; }
    public int? Codigo { get; set; }

    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    [Phone(ErrorMessage = "El teléfono no es un número válido.")]
    public string Telefono { get; set; }
    [Required(ErrorMessage = "La dirección es obligatoria.")]
    [StringLength(200, ErrorMessage = "La dirección no puede exceder los 200 caracteres.")]
    public string Direccion { get; set; }
    public bool Estado { get; set; }
    public byte[] FotoPerfil { get; set; }
    public DateTime? FechaInicioSuscripcion { get; set; }
    public DateTime? FechaFinSuscripcion { get; set; }

    public int? IdSuscripcion { get; set; }
    public Suscripcion? Suscripcion { get; set; }

    public int? IdEntrenador { get; set; }
    public Entrenador? Entrenador { get; set; }



}

using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models
{
    public class Login
    {
        [Required(ErrorMessage = "El campo Correo es obligatorio.")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo Clave es obligatorio.")]
        public string Clave { get; set; }
    }
}

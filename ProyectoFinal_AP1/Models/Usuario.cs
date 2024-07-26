namespace ProyectoFinal_AP1.Models;

public class Usuario
{
    public int IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Genero { get; set; }
    public string Correo { get; set; }
    public string Clave { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public byte[] FotoPerfil { get; set; }

}

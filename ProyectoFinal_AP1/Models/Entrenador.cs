using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_AP1.Models;

public class Entrenador
{
    [Key]
    public int IdEntrenador {  get; set; }
    public string Nombre { get; set; }
    public string Nivel { get; set; }
    public string Genero { get; set; }
    public byte[] FotoPerfil { get; set; }
}

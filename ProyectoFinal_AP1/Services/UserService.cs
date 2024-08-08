using ProyectoFinal_AP1.DAL;
using ProyectoFinal_AP1.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_AP1.Services;

public class UserService
{
    private readonly AppDBContext _context;

    public UserService(AppDBContext context)
    {
        _context = context;
    }

    public async Task<bool> RegisterUser(Usuario usuario)
    {

        if (await _context.Usuarios.AnyAsync(u => u.Correo == usuario.Correo))
        {
            return false;
        }

        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<List<Usuario>> ObtenerUsuarios()
    {
        return await _context.Usuarios.ToListAsync();
    }

    public async Task<Usuario> GetUserByEmailAsync(string email)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(u => u.Correo == email);
    }

    public async Task<Usuario?> GetUserByIdAsync(int userId)
    {
        return await _context.Usuarios.FindAsync(userId);
    }

    public async Task<bool> ActualizarUsuario(Usuario usuario)
    {
        var usuarioExistente = await _context.Usuarios.FindAsync(usuario.IdUsuario);
        if (usuarioExistente == null)
        {
            return false;
        }

        usuarioExistente.Nombre = usuario.Nombre;
        usuarioExistente.Apellido = usuario.Apellido;
        usuarioExistente.Genero = usuario.Genero;
        usuarioExistente.Correo = usuario.Correo;
        usuarioExistente.Clave = usuario.Clave;
        usuarioExistente.Telefono = usuario.Telefono;
        usuarioExistente.Direccion = usuario.Direccion;
        usuarioExistente.Estado = usuario.Estado;
        usuarioExistente.FotoPerfil = usuario.FotoPerfil;
        usuarioExistente.IdSuscripcion = usuario.IdSuscripcion;
        usuarioExistente.IdEntrenador = usuario.IdEntrenador;

 
        if (usuario.IdSuscripcion.HasValue)
        {
            usuarioExistente.FechaInicioSuscripcion = DateTime.Now;
            usuarioExistente.FechaFinSuscripcion = DateTime.Now.AddMonths(1); 
        }

        _context.Usuarios.Update(usuarioExistente);
        await _context.SaveChangesAsync();

        return true;
    }
    public async Task<List<Usuario>> ObtenerUsuariosPorEntrenador(int idEntrenador)
    {
        return await _context.Usuarios.Where(u => u.IdEntrenador == idEntrenador).ToListAsync();
    }

}

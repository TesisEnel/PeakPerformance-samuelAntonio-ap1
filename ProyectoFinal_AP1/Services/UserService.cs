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
}

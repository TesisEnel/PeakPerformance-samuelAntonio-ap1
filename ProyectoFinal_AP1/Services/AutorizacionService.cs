using ProyectoFinal_AP1.DAL;
using ProyectoFinal_AP1.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_AP1.Services;

public class AutorizacionService
{
    private readonly AppDBContext _context;

    public AutorizacionService(AppDBContext context)
    {
        _context = context;
    }

    public async Task<Usuario> GetAuthenticatedUserAsync(string email)
    {
        return await _context.Usuarios.SingleOrDefaultAsync(u => u.Correo == email);
    }
}

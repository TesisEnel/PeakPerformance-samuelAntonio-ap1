using ProyectoFinal_AP1.DAL;
using ProyectoFinal_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ProyectoFinal_AP1.Components.Pages.Usuarios;

namespace ProyectoFinal_AP1.Services;

public class SuscripcionService
{
    private readonly AppDBContext _context;

    public SuscripcionService(AppDBContext context)
    {
        _context = context;
    }
    public async Task GuardarAsync(Suscripcion suscripcion)
    {
        if (suscripcion.IdSuscripcion == 0)
        {
            _context.Suscripciones.Add(suscripcion);
        }
        else
        {
            _context.Suscripciones.Update(suscripcion);
        }

        await _context.SaveChangesAsync();
    }

    public async Task<List<Suscripcion>> GetSuscripcionesAsync()
    {
        return await _context.Suscripciones.ToListAsync();
    }
    public List<Suscripcion> Listar(Expression<Func<Suscripcion, bool>> criterio)
    {
        return _context.Suscripciones
            .AsNoTracking()
            .Where(criterio)
            .ToList();
    }
    public async Task<Suscripcion?> Buscar(int id)
    {
        return await _context.Suscripciones
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.IdSuscripcion == id);
    }
    public int CalcularDiasRestantes(int usuarioId)
    {
        var usuario = _context.Usuarios.Include(u => u.Suscripcion).FirstOrDefault(u => u.IdUsuario == usuarioId);
        if (usuario == null || usuario.Suscripcion == null)
        {
            return -1; 
        }

        var fechaFin = usuario.Suscripcion.FechaFin;
        var diasRestantes = (fechaFin - DateTime.Now).Days;

        return diasRestantes >= 0 ? diasRestantes : 0;
    }
}

using ProyectoFinal_AP1.DAL;
using ProyectoFinal_AP1.Models;
using Microsoft.EntityFrameworkCore;
namespace ProyectoFinal_AP1.Services;

public class EquipoService
{
    private readonly AppDBContext _context;

    public EquipoService(AppDBContext context)
    {
        _context = context;
    }
    public async Task GuardarAsync(Equipos equipo)
    {
        if (equipo.IdEquipo == 0)
        {
            _context.Equipos.Add(equipo);
        }
        else
        {
            _context.Equipos.Update(equipo);
        }

        await _context.SaveChangesAsync();
    }

    public async Task<List<Equipos>> GetEquipoosAsync()
    {
        return await _context.Equipos.ToListAsync();
    }
}

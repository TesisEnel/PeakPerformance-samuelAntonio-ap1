using ProyectoFinal_AP1.DAL;
using ProyectoFinal_AP1.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_AP1.Services;

public class EntrenadorService
{
   
        private readonly AppDBContext _context;

        public EntrenadorService(AppDBContext context)
        {
            _context = context;
        }

        public async Task GuardarEntrenador(Entrenador entrenador)
        {
            _context.Entrenadores.Add(entrenador);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Entrenador>> ObtenerEntrenadores()
        {
            return await _context.Entrenadores.ToListAsync();
        }
    
}

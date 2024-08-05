using ProyectoFinal_AP1.DAL;
using ProyectoFinal_AP1.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_AP1.Services;

public class ProductoService
{
    private readonly AppDBContext _context;

    public ProductoService(AppDBContext context)
    {
        _context = context;
    }
    public async Task GuardarAsync(Producto producto)
    {
        if (producto.IdProducto == 0)
        {
            _context.Productos.Add(producto);
        }
        else
        {
            _context.Productos.Update(producto);
        }

        await _context.SaveChangesAsync();
    }

    public async Task<List<Producto>> GetProductosAsync()
    {
        return await _context.Productos.ToListAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TiendaHD.DAL;
using TiendaHD.Models;

namespace TiendaHD.Services;

public class VentasServices
{
    private readonly Contexto _contexto;

    public VentasServices(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task<bool> Crear(Ventas ventas)
    {
        if (!await Existe(ventas.VentasId))
            return await Insertar(ventas);
        else
            return await Modificar(ventas);
    }

    public async Task<bool> Existe(int id)
    {
        return await _contexto.Ventas
            .AnyAsync(c => c.VentasId == id);
    }

    public async Task<bool> Insertar(Ventas Ventas)
    {
        _contexto.Ventas.Add(Ventas);
        return await _contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(Ventas ventas)
    {
        _contexto.Update(ventas);
        var modifico = await _contexto.SaveChangesAsync() > 0;
        _contexto.Entry(ventas).State = EntityState.Detached;
        return modifico;
    }

    public async Task<bool> Eliminar(int id)
    {
        var cantidad = await _contexto.Ventas
            .Where(c => c.VentasId == id)
            .ExecuteDeleteAsync();

        return cantidad > 0;
    }

    public async Task<Ventas?> Buscar(int id)
    {
        return await _contexto.Ventas
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.VentasId == id);
    }

    public async Task<List<Ventas>> Listar(Expression<Func<Ventas, bool>> criterio)
    {
        return await _contexto.Ventas
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}

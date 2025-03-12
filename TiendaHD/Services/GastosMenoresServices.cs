using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TiendaHD.DAL;
using TiendaHD.Models;

namespace TiendaHD.Services;

public class GastosMenoresServices
{
    private readonly Contexto _contexto;

    public GastosMenoresServices(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task<bool> Crear(GastosMenores gastos)
    {
        if (!await Existe(gastos.GastosMId))
            return await Insertar(gastos);
        else
            return await Modificar(gastos);
    }

    public async Task<bool> Existe(int id)
    {
        return await _contexto.GastosMenores
            .AnyAsync(c => c.GastosMId == id);
    }

    public async Task<bool> Insertar(GastosMenores gastos)
    {
        _contexto.GastosMenores.Add(gastos);
        return await _contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(GastosMenores gastos)
    {
        _contexto.Update(gastos);
        var modifico = await _contexto.SaveChangesAsync() > 0;
        _contexto.Entry(gastos).State = EntityState.Detached;
        return modifico;
    }

    public async Task<bool> Eliminar(int id)
    {
        var cantidad = await _contexto.GastosMenores
            .Where(c => c.GastosMId == id)
            .ExecuteDeleteAsync();

        return cantidad > 0;
    }

    public async Task<GastosMenores?> Buscar(int id)
    {
        return await _contexto.GastosMenores
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.GastosMId == id);
    }

    public async Task<List<GastosMenores>> Listar(Expression<Func<GastosMenores, bool>> criterio)
    {
        return await _contexto.GastosMenores
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}

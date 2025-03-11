using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TiendaHD.DAL;
using TiendaHD.Models;

namespace TiendaHD.Services;

public class FinanciamientoService
{
	private readonly Contexto _contexto;

	public FinanciamientoService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(Financiamientos financiamiento)
	{
		if (!await Existe(financiamiento.FinanciamientoId))
			return await Insertar(financiamiento);
		else
			return await Modificar(financiamiento);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.Financiamientos
			.AnyAsync(c => c.FinanciamientoId == id);
	}

	public async Task<bool> Insertar(Financiamientos financiamiento)
	{
		_contexto.Financiamientos.Add(financiamiento);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Financiamientos financiamiento)
	{
		_contexto.Update(financiamiento);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(financiamiento).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.Financiamientos
			.Where(c => c.FinanciamientoId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<Financiamientos?> Buscar(int id)
	{
		return await _contexto.Financiamientos
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.FinanciamientoId == id);
	}

	public async Task<List<Financiamientos>> Listar(Expression<Func<Financiamientos, bool>> criterio)
	{
		return await _contexto.Financiamientos
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}

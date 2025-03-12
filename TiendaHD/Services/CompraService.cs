using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TiendaHD.DAL;
using TiendaHD.Models;

namespace TiendaHD.Services;

public class CompraService
{
	private readonly Contexto _contexto;

	public CompraService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(Compras compra)
	{
		if (!await Existe(compra.CompraId))
			return await Insertar(compra);
		else
			return await Modificar(compra);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.Compras
			.AnyAsync(c => c.CompraId == id);
	}

	public async Task<bool> Insertar(Compras compra)
	{
		_contexto.Compras.Add(compra);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Compras compra)
	{
		_contexto.Update(compra);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(compra).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.Compras
			.Where(c => c.CompraId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<Compras?> Buscar(int id)
	{
		return await _contexto.Compras
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.CompraId == id);
	}

	public async Task<List<Compras>> Listar(Expression<Func<Compras, bool>> criterio)
	{
		return await _contexto.Compras
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}

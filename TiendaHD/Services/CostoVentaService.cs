using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TiendaHD.DAL;
using TiendaHD.Migrations;
using TiendaHD.Models;

namespace TiendaHD.Services;

public class CostoVentaService
{
	private readonly Contexto _contexto;

	public CostoVentaService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(CostoVentas costoVenta)
	{
		if (!await Existe(costoVenta.CostoVentaId))
			return await Insertar(costoVenta);
		else
			return await Modificar(costoVenta);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.CostoVentas
			.AnyAsync(c => c.CostoVentaId == id);
	}

	public async Task<bool> Insertar(CostoVentas costoVenta)
	{
		_contexto.CostoVentas.Add(costoVenta);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(CostoVentas costoVenta)
	{
		_contexto.Update(costoVenta);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(costoVenta).State = EntityState.Detached;
		return modifico;
	}

	public async Task<List<CostoVentas>> Listar(Expression<Func<CostoVentas, bool>> criterio)
	{
		return await _contexto.CostoVentas
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}

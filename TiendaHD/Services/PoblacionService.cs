using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TiendaHD.DAL;
using TiendaHD.Models;

namespace TiendaHD.Services;

public class PoblacionService
{
	private readonly Contexto _contexto;

	public PoblacionService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(Poblacion poblacion)
	{
		if (!await Existe(poblacion.PoblacionId))
			return await Insertar(poblacion);
		else
			return await Modificar(poblacion);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.Poblacion
			.AnyAsync(c => c.PoblacionId == id);
	}

	public async Task<bool> Insertar(Poblacion poblacion)
	{
		_contexto.Poblacion.Add(poblacion);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Poblacion poblacion)
	{
		_contexto.Update(poblacion);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(poblacion).State = EntityState.Detached;
		return modifico;
	}

	public async Task<List<Poblacion>> Listar(Expression<Func<Poblacion, bool>> criterio)
	{
		return await _contexto.Poblacion
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}

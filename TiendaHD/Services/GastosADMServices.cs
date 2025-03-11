using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TiendaHD.DAL;
using TiendaHD.Models;

namespace TiendaHD.Services
{
    public class GastosADMServices
    {

        private readonly Contexto _contexto;

        public GastosADMServices(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Crear(GastosADM gastos)
        {
            if (!await Existe(gastos.GastosADMId))
                return await Insertar(gastos);
            else
                return await Modificar(gastos);
        }

        public async Task<bool> Existe(int id)
        {
            return await _contexto.GastosADM
                .AnyAsync(c => c.GastosADMId == id);
        }

        public async Task<bool> Insertar(GastosADM gastos)
        {
            _contexto.GastosADM.Add(gastos);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(GastosADM gastos)
        {
            _contexto.Update(gastos);
            var modifico = await _contexto.SaveChangesAsync() > 0;
            _contexto.Entry(gastos).State = EntityState.Detached;
            return modifico;
        }

        public async Task<bool> Eliminar(int id)
        {
            var cantidad = await _contexto.GastosADM
                .Where(c => c.GastosADMId == id)
                .ExecuteDeleteAsync();

            return cantidad > 0;
        }

        public async Task<GastosADM?> Buscar(int id)
        {
            return await _contexto.GastosADM
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.GastosADMId == id);
        }

        public async Task<List<GastosADM>> Listar(Expression<Func<GastosADM, bool>> criterio)
        {
            return await _contexto.GastosADM
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}

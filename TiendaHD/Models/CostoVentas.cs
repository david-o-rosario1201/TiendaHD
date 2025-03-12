using System.ComponentModel.DataAnnotations;

namespace TiendaHD.Models;

public class CostoVentas
{
	[Key]
	public int CostoVentaId { get; set; }

    public decimal Costo { get; set; }

    public decimal Total { get; set; }
}

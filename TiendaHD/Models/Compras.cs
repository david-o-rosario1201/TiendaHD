using System.ComponentModel.DataAnnotations;

namespace TiendaHD.Models;

public class Compras
{
	[Key]
	public int CompraId { get; set; }

	public int CantidadPantalones { get; set; }

	public int CantidadPerfumes { get; set; }

	public int CantidadSweater { get; set; }

	public decimal PrecioPantalones { get; set; }

	public decimal PrecioPerfumes { get; set; }

	public decimal PrecioSweater { get; set; }

	public decimal PagoChofer { get; set; }

	public decimal PagoComidaChofer { get; set; }

	public decimal PagoGasolina { get; set; }
}
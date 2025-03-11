using System.ComponentModel.DataAnnotations;

namespace TiendaHD.Models;

public class GastosADM
{
	[Key]
	public int GastosADMId { get; set; }
	public string GastosADMName { get; set; }
	public float ValorGastoADM { get; set; }
}

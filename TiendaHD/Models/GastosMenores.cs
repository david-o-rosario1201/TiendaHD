using System.ComponentModel.DataAnnotations;

namespace TiendaHD.Models;

public class GastosMenores
{
	[Key]
    public int GastosMId { get; set; }
    public string GastosMName { get; set; }
    public float ValorGastosM { get; set; }
}

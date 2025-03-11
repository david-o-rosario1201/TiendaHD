using System.ComponentModel.DataAnnotations;

namespace TiendaHD.Models;

public class Financiamientos
{
    [Key]
    public int FinanciamientoId { get; set; }

    public string Detalle { get; set; }

    public decimal CuotaMensual { get; set; }
}

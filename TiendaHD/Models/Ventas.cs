namespace TiendaHD.Models;
public class Ventas
{
    public int VentasId { get; set; }
    public string Articulo { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Total { get; set; }
}

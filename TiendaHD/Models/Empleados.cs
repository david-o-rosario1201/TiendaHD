using System.ComponentModel.DataAnnotations;

namespace TiendaHD.Models;

public class Empleados
{
	[Key]
	public int EmpleadoId { get; set; }

    public string Nombre { get; set; }

    public string Puesto { get; set; }

    public decimal Salario { get; set; }
}

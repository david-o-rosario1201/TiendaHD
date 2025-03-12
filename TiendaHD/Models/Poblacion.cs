using System.ComponentModel.DataAnnotations;

namespace TiendaHD.Models;

public class Poblacion
{
    [Key]
    public int PoblacionId { get; set; }

    public int PoblacionTotal { get; set; } = 150000;

    public int PoblacionCompradora { get; set; }
}

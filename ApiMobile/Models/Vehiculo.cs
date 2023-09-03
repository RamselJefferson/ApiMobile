using System;
using System.Collections.Generic;

namespace ApiMobile.Models;

public partial class Vehiculo
{
    public int? MarId { get; set; }

    public int? ModId { get; set; }

    public string? VehDecripcion { get; set; }

    public decimal? Precio { get; set; }

    public string? Estatus { get; set; }

    public int VehId { get; set; }

    public int? Año { get; set; }

    public string? Img { get; set; }
}

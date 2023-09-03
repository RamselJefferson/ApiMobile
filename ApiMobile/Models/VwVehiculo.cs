using System;
using System.Collections.Generic;

namespace ApiMobile.Models;

public partial class VwVehiculo
{
    public int Vehid { get; set; }

    public string? VehDecripcion { get; set; }

    public string? MarDecripcion { get; set; }

    public string? ModDescripcion { get; set; }

    public decimal? Precio { get; set; }

    public string? Img { get; set; }

    public int? Año { get; set; }

    public string? Estatus { get; set; }
}

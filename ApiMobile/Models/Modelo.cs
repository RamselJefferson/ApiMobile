using System;
using System.Collections.Generic;

namespace ApiMobile.Models;

public partial class Modelo
{
    public int ModId { get; set; }

    public string? ModDescripcion { get; set; }

    public int? MarId { get; set; }

    public virtual Marca? Mar { get; set; }
}

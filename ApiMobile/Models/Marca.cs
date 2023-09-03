using System;
using System.Collections.Generic;

namespace ApiMobile.Models;

public partial class Marca
{
    public int MarId { get; set; }

    public string? MarDecripcion { get; set; }

    public virtual ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
}

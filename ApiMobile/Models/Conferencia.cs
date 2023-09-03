using System;
using System.Collections.Generic;

namespace ApiMobile.Models;

public partial class Conferencia
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public string? Duracion { get; set; }

    public string? Creador { get; set; }
}

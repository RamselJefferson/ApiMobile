using System;
using System.Collections.Generic;

namespace ApiMobile.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? UsuarioName { get; set; }

    public string? Password { get; set; }

    public int? Rol { get; set; }

    public int? Telefono { get; set; }

    public int? Email { get; set; }
}

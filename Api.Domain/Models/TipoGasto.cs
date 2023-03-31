using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class TipoGasto
{
    public Guid Id { get; set; }

    public string? Detalle { get; set; }

    public string? Estado { get; set; }
}

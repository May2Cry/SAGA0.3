using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class Iniciativas
{
    public Guid Id { get; set; }

    public string? NombreIniciativa { get; set; }

    public string? DescripcionIniciativa { get; set; }

    public decimal? Monto { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Proyectos> Proyectos { get; } = new List<Proyectos>();
}

using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class Indicadores
{
    public Guid Id { get; set; }

    public Guid IdProyecto { get; set; }

    public string? NombreIndicador { get; set; }

    public string? SiglaIndicador { get; set; }

    public string? TipoIndicador { get; set; }

    public decimal? ValorIndicador { get; set; }

    public string? Estado { get; set; }

    public virtual Proyectos IdProyectoNavigation { get; set; } = null!;
}

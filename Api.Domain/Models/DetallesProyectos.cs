using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class DetallesProyectos
{
    public Guid Id { get; set; }

    public Guid? IdProyecto { get; set; }

    public string? ActividadRealizada { get; set; }

    public string? DetalleActividad { get; set; }

    public string? PorcentajeAvance { get; set; }

    public string? Prioridad { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinal { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<DocumentosAdjuntos> DocumentosAdjuntos { get; } = new List<DocumentosAdjuntos>();

    public virtual Proyectos? IdProyectoNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class DocumentosAdjuntos
{
    public Guid Id { get; set; }

    public Guid? IdDetalleProyecto { get; set; }

    public string? NombreDocumento { get; set; }

    public string? FilePath { get; set; }

    public string? Extension { get; set; }

    public DateTime? FechaCreado { get; set; }

    public virtual DetallesProyectos? IdDetalleProyectoNavigation { get; set; }
}

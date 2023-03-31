using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class DetallesGastos
{
    public Guid Id { get; set; }

    public Guid? TipoGastoId { get; set; }

    public string? NumeroFactura { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? IdentificacionProveedor { get; set; }

    public string? NombresProveedor { get; set; }

    public decimal? Valor { get; set; }

    public Guid? IdProyecto { get; set; }

    public virtual Proyectos? IdProyectoNavigation { get; set; }

    public virtual TipoGasto? TipoGasto { get; set; }
}

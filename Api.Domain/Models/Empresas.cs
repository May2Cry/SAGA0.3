using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class Empresas
{
    public Guid Id { get; set; }

    public string? Ruc { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Estado { get; set; }

    public Guid? UbicacionGeograficaId { get; set; }

    public virtual ICollection<Proyectos> Proyectos { get; } = new List<Proyectos>();

    public virtual UbicacionGeografica? UbicacionGeografica { get; set; }
}

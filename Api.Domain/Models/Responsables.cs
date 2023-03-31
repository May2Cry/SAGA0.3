using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class Responsables
{
    public Guid Id { get; set; }

    public string? Nombres { get; set; }

    public Guid? CargoId { get; set; }

    public string? Estado { get; set; }

    public string? NombreCargo { get; set; }

    public virtual Cargos? Cargo { get; set; }

    public virtual ICollection<Proyectos> Proyectos { get; } = new List<Proyectos>();
}

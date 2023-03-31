using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class Cargos
{
    public Guid Id { get; set; }

    public string? DescripcionCargo { get; set; }

    public virtual ICollection<Responsables> Responsables { get; } = new List<Responsables>();
}

using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class PlanEmpresarial
{
    public Guid Id { get; set; }

    public string? Objetivo { get; set; }

    public string? MetaPrincipal { get; set; }

    public string? Indicador { get; set; }

    public string? Politica { get; set; }

    public string? MetaSecundaria { get; set; }

    public virtual ICollection<Proyectos> Proyectos { get; } = new List<Proyectos>();
}

using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class UbicacionGeografica
{
    public Guid Id { get; set; }

    public string? Pais { get; set; }

    public string? Provincia { get; set; }

    public string? Canton { get; set; }

    public string? Parroquia { get; set; }

    public string? Sector { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public virtual ICollection<Empresas> Empresas { get; } = new List<Empresas>();

    public virtual ICollection<Proyectos> Proyectos { get; } = new List<Proyectos>();
}

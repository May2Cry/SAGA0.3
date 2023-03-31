using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class CertificadoAmbiental
{
    public Guid Id { get; set; }

    public string? NombreCertificado { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Proyectos> Proyectos { get; } = new List<Proyectos>();
}

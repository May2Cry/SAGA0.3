using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class Proyectos
{
    public Guid? Id { get; set; }

    public string? TituloProyecto { get; set; }

    public string? DescripcionProyecto { get; set; }

    public decimal? Anio { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinal { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? UsuarioCrea { get; set; }

    public Guid? CertificadoAmbientalId { get; set; }

    public Guid? ResponsablesId { get; set; }

    public Guid? UbicacionGeograficaId { get; set; }

    public Guid? IdIniciativa { get; set; }

    public Guid? IdEmpresa { get; set; }

    public Guid? IdPlanEmpresarial { get; set; }

    public virtual CertificadoAmbiental CertificadoAmbiental { get; set; } = null!;

    public virtual ICollection<DetallesProyectos> DetallesProyectos { get; } = new List<DetallesProyectos>();

    public virtual Empresas? IdEmpresaNavigation { get; set; }

    public virtual Iniciativas? IdIniciativaNavigation { get; set; }

    public virtual PlanEmpresarial? IdPlanEmpresarialNavigation { get; set; }

    public virtual ICollection<Indicadores> Indicadores { get; } = new List<Indicadores>();

    public virtual Responsables Responsables { get; set; } = null!;

    public virtual UbicacionGeografica? UbicacionGeografica { get; set; }
}

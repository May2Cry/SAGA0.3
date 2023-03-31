using System;
using System.Collections.Generic;

namespace SAGA0._3.Api.Domain.Models;

public partial class Sysdiagrams
{
    public string Name { get; set; } = null!;

    public int PrincipalId { get; set; }

    public int DiagramId { get; set; }

    public int? Version { get; set; }

    public byte[]? Definition { get; set; }
}

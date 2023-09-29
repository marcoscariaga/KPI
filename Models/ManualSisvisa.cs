using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ManualSisvisa")]
[Index("TipoComponenteId", "Codigo", Name = "UQ__ManualSi__2EFD63FD2A363CC5", IsUnique = true)]
public partial class ManualSisvisa
{
    [Key]
    public int Id { get; set; }

    public int TipoComponenteId { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Titulo { get; set; } = null!;

    public string? Observacao { get; set; }

    public string Descricao { get; set; } = null!;

    public int VisibilidadeId { get; set; }

    public int SituacaoId { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("DescricaoAutoInfracao")]
public partial class DescricaoAutoInfracao
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string TextoAuto { get; set; } = null!;

    [StringLength(220)]
    [Unicode(false)]
    public string? CapitulacaoLegal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CodigoDoOrgao { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? UfAutuado { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? LocalDaInfracao { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? OrgaoAtuante { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? MoedaMonetaria { get; set; }

    [StringLength(220)]
    [Unicode(false)]
    public string? Penalidade { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? NomeDaSecretaria { get; set; }
}

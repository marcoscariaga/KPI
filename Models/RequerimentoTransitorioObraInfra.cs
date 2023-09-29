using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoTransitorioObraInfra")]
public partial class RequerimentoTransitorioObraInfra
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorioDeObra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? InscricaoMunicipal { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Cnpj { get; set; } = null!;

    public int? TipoDeInfra { get; set; }
}

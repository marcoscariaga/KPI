using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoTransitorioDeObra")]
public partial class RequerimentoTransitorioDeObra
{
    [Key]
    public int Id { get; set; }

    public int? IdDoRequerimentoTransitorio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Cnpj { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? EnderecoEmpresa { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EnderecoObra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomeObra { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string InscricaoMunicipal { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? LicencaObraAssociada { get; set; }
}

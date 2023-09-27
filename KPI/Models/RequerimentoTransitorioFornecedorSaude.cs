using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoTransitorioFornecedorSaude")]
public partial class RequerimentoTransitorioFornecedorSaude
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    public bool CamaFechada { get; set; }

    public bool CamaAberta { get; set; }

    public bool CamaCirurgica { get; set; }

    public int QuantidadeLeito { get; set; }

    public int QuantidadePostos { get; set; }

    public int QuantidadeLeitoPosto { get; set; }

    public int QuantidadeCadeiraHidratacao { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string DescricaoAmbulancia { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string DescricaoPosto { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string DescricaoOutros { get; set; } = null!;
}

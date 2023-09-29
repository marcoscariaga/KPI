using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class RequerimentoTransitorioFornecedorAlimento
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    public int LocalProducao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string RazaoSocialLocalProducao { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string Cnpj { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string EnderecoLocalProducao { get; set; } = null!;

    public int TipoAlimentoComercializado { get; set; }

    public int FormaDistribuicao { get; set; }

    public int QuantidadePontoDistribuicao { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Outros { get; set; }
}

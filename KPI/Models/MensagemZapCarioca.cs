using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("MensagemZapCarioca")]
public partial class MensagemZapCarioca
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataEvento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string TipoRequisicaoSisvisa { get; set; } = null!;

    public int? InscricaoMunicipal { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfCnpj { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNome { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfCariocaDigital { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? EmailCariocaDigital { get; set; }

    public long? CodigoGrupo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Celular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Assunto { get; set; } = null!;

    public string Mensagem { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DataEnvio { get; set; }

    public long? CodigoMensagem { get; set; }

    public string? CodigoMensagemRetorno { get; set; }

    public string? CodigoMensagemRetornoErro { get; set; }
}

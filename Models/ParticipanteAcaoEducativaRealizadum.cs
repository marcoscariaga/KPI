using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class ParticipanteAcaoEducativaRealizadum
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeTreinando { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string CpfTreinando { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RgTreinando { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? FuncaoTreinando { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CnpjEmpresa { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialEmpresa { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NomeFantasiaEmpresa { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EnderecoEmpresa { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TelefoneEmpresa { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmailEmpresa { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroRegistroCertificado { get; set; }

    public int? NumeroLivroCertificado { get; set; }

    public int? NumeroFolhaCertificado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRegistroCertificado { get; set; }

    public bool CertificadoEmitido { get; set; }

    public int AcaoEducativaRealizadaId { get; set; }

    [ForeignKey("AcaoEducativaRealizadaId")]
    [InverseProperty("ParticipanteAcaoEducativaRealizada")]
    public virtual AcaoEducativaRealizadum AcaoEducativaRealizada { get; set; } = null!;
}

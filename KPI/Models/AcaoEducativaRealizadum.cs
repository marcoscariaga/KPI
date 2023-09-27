using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class AcaoEducativaRealizadum
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataRealizacao { get; set; }

    public int TipoPublicoAlvoAcaoEducativaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    public bool AcaoEducativaInterna { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NomeInstrutorParceiro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomeResponsavelRegistroCertificado { get; set; }

    public int CursoParaAcaoEducativaId { get; set; }

    public int? ServidorId { get; set; }

    public int? InstrutorSubvisaId { get; set; }

    public int? ParceiroParaAcaoEducativaId { get; set; }

    [ForeignKey("CursoParaAcaoEducativaId")]
    [InverseProperty("AcaoEducativaRealizada")]
    public virtual CursoParaAcaoEducativa CursoParaAcaoEducativa { get; set; } = null!;

    [ForeignKey("InstrutorSubvisaId")]
    [InverseProperty("AcaoEducativaRealizadumInstrutorSubvisas")]
    public virtual Servidor? InstrutorSubvisa { get; set; }

    [ForeignKey("ParceiroParaAcaoEducativaId")]
    [InverseProperty("AcaoEducativaRealizada")]
    public virtual ParceiroParaAcaoEducativa? ParceiroParaAcaoEducativa { get; set; }

    [InverseProperty("AcaoEducativaRealizada")]
    public virtual ICollection<ParticipanteAcaoEducativaRealizadum> ParticipanteAcaoEducativaRealizada { get; set; } = new List<ParticipanteAcaoEducativaRealizadum>();

    [ForeignKey("ServidorId")]
    [InverseProperty("AcaoEducativaRealizadumServidors")]
    public virtual Servidor? Servidor { get; set; }
}

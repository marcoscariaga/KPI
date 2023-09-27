using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("NumeroAutorizacao", Name = "UQ__Autoriza__E615DCA848EFCE0F", IsUnique = true)]
public partial class AutorizacaoSanitarium
{
    [Key]
    public int Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string NumeroAutorizacao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataConcessao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataValidade { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRevogacao { get; set; }

    public int SituacaoId { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string LoginRede { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    public int RequerenteId { get; set; }

    public int RequerimentoAdmId { get; set; }

    public int? JustificativaId { get; set; }

    [ForeignKey("JustificativaId")]
    [InverseProperty("AutorizacaoSanitaria")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("RequerenteId")]
    [InverseProperty("AutorizacaoSanitaria")]
    public virtual Requerente Requerente { get; set; } = null!;

    [ForeignKey("RequerimentoAdmId")]
    [InverseProperty("AutorizacaoSanitaria")]
    public virtual RequerimentoAdministrativo RequerimentoAdm { get; set; } = null!;
}

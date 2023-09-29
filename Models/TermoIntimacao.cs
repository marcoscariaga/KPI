using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TermoIntimacao")]
[Index("NumeroTermoServidor", Name = "AK_NumeroTermoServidor")]
[Index("NumeroTermoSisvisa", Name = "AK_NumeroTermoSisvisa")]
[Index("NumeroTermoServidor", Name = "UQ__TermoInt__29DD6E165F1F0650", IsUnique = true)]
[Index("NumeroTermoSisvisa", Name = "UQ__TermoInt__BA4C65267ECCBBD3", IsUnique = true)]
[Index("TarefaId", Name = "gqs_carga")]
public partial class TermoIntimacao
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermoSisvisa { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermoServidor { get; set; } = null!;

    public int SituacaoId { get; set; }

    public int SituacaoAlocacaoId { get; set; }

    public int TipoId { get; set; }

    public int TipoPrazoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataEmissao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataVencimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataVencimentoOriginal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataMonitoramento { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Anexo { get; set; } = null!;

    public string? Observacao { get; set; }

    public bool Alimentos { get; set; }

    public bool Saude { get; set; }

    public bool Zoonoses { get; set; }

    public int ServidorQueLavrouId { get; set; }

    public int? ServidorQueAtualizouId { get; set; }

    public int TarefaId { get; set; }

    public int? EditalInterdicaoId { get; set; }

    public int? TermoAnteriorId { get; set; }

    public bool GeradoAplicativoMovel { get; set; }

    public bool ValidarSisvisa { get; set; }

    [ForeignKey("EditalInterdicaoId")]
    [InverseProperty("TermoIntimacaos")]
    public virtual EditalInterdicao? EditalInterdicao { get; set; }

    [InverseProperty("TermoIntimacao")]
    public virtual ICollection<EditalInterdicao> EditalInterdicaos { get; set; } = new List<EditalInterdicao>();

    [InverseProperty("TermoAnterior")]
    public virtual ICollection<TermoIntimacao> InverseTermoAnterior { get; set; } = new List<TermoIntimacao>();

    [InverseProperty("TermoIntimacao")]
    public virtual ICollection<NotificacaoInfracao> NotificacaoInfracaos { get; set; } = new List<NotificacaoInfracao>();

    [InverseProperty("TermoIntimacao")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [ForeignKey("ServidorQueAtualizouId")]
    [InverseProperty("TermoIntimacaoServidorQueAtualizous")]
    public virtual Servidor? ServidorQueAtualizou { get; set; }

    [ForeignKey("ServidorQueLavrouId")]
    [InverseProperty("TermoIntimacaoServidorQueLavrous")]
    public virtual Servidor ServidorQueLavrou { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("TermoIntimacaos")]
    public virtual Tarefa Tarefa { get; set; } = null!;

    [ForeignKey("TermoAnteriorId")]
    [InverseProperty("InverseTermoAnterior")]
    public virtual TermoIntimacao? TermoAnterior { get; set; }
}

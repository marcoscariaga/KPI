using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("NotificacaoInfracao")]
[Index("NumeroAutoDeInfracao", Name = "AK_NumeroAutoDeInfracao")]
[Index("NumeroSisvisa", Name = "AK_NumeroSisvisa")]
[Index("NumeroAutoDeInfracao", Name = "UQ__Notifica__1A11A29153AD53A4", IsUnique = true)]
[Index("NumeroSisvisa", Name = "UQ__Notifica__31CEF09262307D25", IsUnique = true)]
public partial class NotificacaoInfracao
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroSisvisa { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroAutoDeInfracao { get; set; } = null!;

    [Column(TypeName = "decimal(19, 5)")]
    public decimal ValorDaMulta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataNotificacao { get; set; }

    public int SituacaoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Anexo { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    public bool Alimentos { get; set; }

    public bool Saude { get; set; }

    public bool Zoonoses { get; set; }

    public int ServidorQueLavrouId { get; set; }

    public int? ServidorQueAtualizouId { get; set; }

    public int? TermoIntimacaoId { get; set; }

    public int TarefaId { get; set; }

    [InverseProperty("NotificacaoInfracao")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [ForeignKey("ServidorQueAtualizouId")]
    [InverseProperty("NotificacaoInfracaoServidorQueAtualizous")]
    public virtual Servidor? ServidorQueAtualizou { get; set; }

    [ForeignKey("ServidorQueLavrouId")]
    [InverseProperty("NotificacaoInfracaoServidorQueLavrous")]
    public virtual Servidor ServidorQueLavrou { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("NotificacaoInfracaos")]
    public virtual Tarefa Tarefa { get; set; } = null!;

    [ForeignKey("TermoIntimacaoId")]
    [InverseProperty("NotificacaoInfracaos")]
    public virtual TermoIntimacao? TermoIntimacao { get; set; }
}

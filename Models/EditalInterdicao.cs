using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("EditalInterdicao")]
[Index("NumeroTermoServidor", Name = "AK_NumeroTermoServidor")]
[Index("NumeroTermoSisvisa", Name = "AK_NumeroTermoSisvisa")]
[Index("NumeroTermoServidor", Name = "UQ__EditalIn__29DD6E1650D0E6F9", IsUnique = true)]
[Index("NumeroTermoSisvisa", Name = "UQ__EditalIn__BA4C65265105F123", IsUnique = true)]
public partial class EditalInterdicao
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermoSisvisa { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermoServidor { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataHoraInterdicao { get; set; }

    public int SituacaoId { get; set; }

    public int SituacaoAlocacaoId { get; set; }

    public int TipoId { get; set; }

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

    public int TermoIntimacaoId { get; set; }

    public bool GeradoAplicativoMovel { get; set; }

    public bool ValidarSisvisa { get; set; }

    public bool MonitoramentoAtualizado { get; set; }

    [ForeignKey("ServidorQueAtualizouId")]
    [InverseProperty("EditalInterdicaoServidorQueAtualizous")]
    public virtual Servidor? ServidorQueAtualizou { get; set; }

    [ForeignKey("ServidorQueLavrouId")]
    [InverseProperty("EditalInterdicaoServidorQueLavrous")]
    public virtual Servidor ServidorQueLavrou { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("EditalInterdicaos")]
    public virtual Tarefa Tarefa { get; set; } = null!;

    [ForeignKey("TermoIntimacaoId")]
    [InverseProperty("EditalInterdicaos")]
    public virtual TermoIntimacao TermoIntimacao { get; set; } = null!;

    [InverseProperty("EditalInterdicao")]
    public virtual ICollection<TermoIntimacao> TermoIntimacaos { get; set; } = new List<TermoIntimacao>();
}

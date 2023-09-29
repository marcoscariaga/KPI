using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("OrdemServico")]
[Index("Numero", Name = "AK_OrdemServico")]
[Index("Numero", Name = "UQ__OrdemSer__7E532BC67B113988", IsUnique = true)]
[Index("SituacaoId", Name = "gqs_ordemservico")]
public partial class OrdemServico
{
    [Key]
    public int Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataParaExecucao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataLimiteRegistro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicioExecucao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFimExecucao { get; set; }

    public int SituacaoId { get; set; }

    public int SegmentoDeInspecaoId { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    public bool AlocadaAplicativoMovel { get; set; }

    [Column("DataInicioDownloadOS", TypeName = "datetime")]
    public DateTime? DataInicioDownloadOs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFimSincronismoOs { get; set; }

    public string? JustiticativaCancelamentoAlocacaoOsAplicativo { get; set; }

    [InverseProperty("OrdemServico")]
    public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
}

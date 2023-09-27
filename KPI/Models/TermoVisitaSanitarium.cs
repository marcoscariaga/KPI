using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("NumeroTermoServidor", Name = "AK_NumeroTermoServidor")]
[Index("NumeroTermoSisvisa", Name = "AK_NumeroTermoSisvisa")]
[Index("NumeroTermoServidor", Name = "UQ__TermoVis__29DD6E1661FB72FB", IsUnique = true)]
[Index("NumeroTermoSisvisa", Name = "UQ__TermoVis__BA4C65260579B962", IsUnique = true)]
public partial class TermoVisitaSanitarium
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

    public bool TeveInspecao { get; set; }

    public bool TeveAutoInfracao { get; set; }

    public bool RealizouAcaoEducativa { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataVisita { get; set; }

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

    public int TarefaId { get; set; }

    public bool TeveDesinterdicao { get; set; }

    public bool GeradoAplicativoMovel { get; set; }

    [InverseProperty("TermoVisitaSanitaria")]
    public virtual ICollection<Laudo> Laudos { get; set; } = new List<Laudo>();

    [ForeignKey("ServidorQueAtualizouId")]
    [InverseProperty("TermoVisitaSanitariumServidorQueAtualizous")]
    public virtual Servidor? ServidorQueAtualizou { get; set; }

    [ForeignKey("ServidorQueLavrouId")]
    [InverseProperty("TermoVisitaSanitariumServidorQueLavrous")]
    public virtual Servidor ServidorQueLavrou { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("TermoVisitaSanitariaNavigation")]
    public virtual Tarefa Tarefa { get; set; } = null!;

    [InverseProperty("TermoVisitaSanitaria")]
    public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
}

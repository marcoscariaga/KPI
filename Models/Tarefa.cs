using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Tarefa")]
[Index("OrdemServicoId", Name = "gqs_tarefasdaO")]
public partial class Tarefa
{
    [Key]
    public int Id { get; set; }

    public int SituacaoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DescricaoProdutoDeColeta { get; set; }

    public string? JustificativaInclusaoEmergencial { get; set; }

    public int OrdemServicoId { get; set; }

    public int? JustificaticaId { get; set; }

    public int? TermoVisitaSanitariaId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Logradouro { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Cidade { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    public int CepNumero { get; set; }

    public short CepComplemento { get; set; }

    public string? Observacao { get; set; }

    public bool? Sincronizada { get; set; }

    [Column("PTAD")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Ptad { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Justificativa { get; set; }

    [Column("StatusPTAD")]
    public int? StatusPtad { get; set; }

    [InverseProperty("Tarefa")]
    public virtual ICollection<AcaoEducativaO> AcaoEducativaOs { get; set; } = new List<AcaoEducativaO>();

    [InverseProperty("Tarefa")]
    public virtual ICollection<AcaoSisvisaTarefa> AcaoSisvisaTarefas { get; set; } = new List<AcaoSisvisaTarefa>();

    [InverseProperty("Tarefa")]
    public virtual ICollection<EditalInterdicao> EditalInterdicaos { get; set; } = new List<EditalInterdicao>();

    [ForeignKey("JustificaticaId")]
    [InverseProperty("Tarefas")]
    public virtual Justificativa? Justificatica { get; set; }

    [InverseProperty("Tarefa")]
    public virtual ICollection<NotificacaoInfracao> NotificacaoInfracaos { get; set; } = new List<NotificacaoInfracao>();

    [ForeignKey("OrdemServicoId")]
    [InverseProperty("Tarefas")]
    public virtual OrdemServico OrdemServico { get; set; } = null!;

    [InverseProperty("Tarefa")]
    public virtual ICollection<TermoApreensaoAmostraAnalise> TermoApreensaoAmostraAnalises { get; set; } = new List<TermoApreensaoAmostraAnalise>();

    [InverseProperty("Tarefa")]
    public virtual ICollection<TermoApreensao> TermoApreensaos { get; set; } = new List<TermoApreensao>();

    [InverseProperty("Tarefa")]
    public virtual ICollection<TermoIntimacao> TermoIntimacaos { get; set; } = new List<TermoIntimacao>();

    [ForeignKey("TermoVisitaSanitariaId")]
    [InverseProperty("Tarefas")]
    public virtual TermoVisitaSanitarium? TermoVisitaSanitaria { get; set; }

    [InverseProperty("Tarefa")]
    public virtual ICollection<TermoVisitaSanitarium> TermoVisitaSanitariaNavigation { get; set; } = new List<TermoVisitaSanitarium>();
}

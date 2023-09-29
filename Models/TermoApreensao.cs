using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TermoApreensao")]
[Index("NumeroTermoServidor", Name = "AK_NumeroTermoServidor")]
[Index("NumeroTermoSisvisa", Name = "AK_NumeroTermoSisvisa")]
[Index("NumeroTermoServidor", Name = "UQ__TermoApr__29DD6E1659662CFA", IsUnique = true)]
[Index("NumeroTermoSisvisa", Name = "UQ__TermoApr__BA4C65267172C0B5", IsUnique = true)]
public partial class TermoApreensao
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
    public DateTime DataHoraApreensao { get; set; }

    public int SituacaoId { get; set; }

    public int TipoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Anexo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? AnexoRelacaoProdutos { get; set; }

    public bool Alimentos { get; set; }

    public bool Saude { get; set; }

    public bool Zoonoses { get; set; }

    public bool DetalhaRelacaoProdutos { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Observacoes { get; set; }

    public int ServidorQueLavrouId { get; set; }

    public int? ServidorQueAtualizouId { get; set; }

    public int CapitulacaoLegalId { get; set; }

    public int TarefaId { get; set; }

    public int? TermoApreensaoAmostraAnaliseId { get; set; }

    public bool GeradoAplicativoMovel { get; set; }

    [ForeignKey("CapitulacaoLegalId")]
    [InverseProperty("TermoApreensaos")]
    public virtual CapitulacaoLegalInspecao CapitulacaoLegal { get; set; } = null!;

    [InverseProperty("TermoApreensao")]
    public virtual ICollection<ProdutoTermoApreensao> ProdutoTermoApreensaos { get; set; } = new List<ProdutoTermoApreensao>();

    [InverseProperty("TermoApreensao")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [ForeignKey("ServidorQueAtualizouId")]
    [InverseProperty("TermoApreensaoServidorQueAtualizous")]
    public virtual Servidor? ServidorQueAtualizou { get; set; }

    [ForeignKey("ServidorQueLavrouId")]
    [InverseProperty("TermoApreensaoServidorQueLavrous")]
    public virtual Servidor ServidorQueLavrou { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("TermoApreensaos")]
    public virtual Tarefa Tarefa { get; set; } = null!;

    [ForeignKey("TermoApreensaoAmostraAnaliseId")]
    [InverseProperty("TermoApreensaos")]
    public virtual TermoApreensaoAmostraAnalise? TermoApreensaoAmostraAnalise { get; set; }

    [InverseProperty("TermoApreensao")]
    public virtual ICollection<TermoApreensaoAmostraAnalise> TermoApreensaoAmostraAnalises { get; set; } = new List<TermoApreensaoAmostraAnalise>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Laudo")]
[Index("NumeroLaudo", Name = "AK_NumeroLaudo")]
[Index("NumeroLaudo", Name = "UQ__Laudo__9872526C5B837F96", IsUnique = true)]
public partial class Laudo
{
    [Key]
    public int Id { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string NumeroLaudo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataEmissao { get; set; }

    public int TipoLaudoId { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    public int ResultadoDaAnaliseId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Anexo { get; set; } = null!;

    public int LaboratorioId { get; set; }

    public int? TermoApreensaoAmostraAnaliseId { get; set; }

    public int? AcaoSisvisaId { get; set; }

    public int? TermoVisitaSanitariaId { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    [InverseProperty("Laudos")]
    public virtual AcaoSisvisa? AcaoSisvisa { get; set; }

    [ForeignKey("LaboratorioId")]
    [InverseProperty("Laudos")]
    public virtual Laboratorio Laboratorio { get; set; } = null!;

    [InverseProperty("Laudo")]
    public virtual ICollection<NotificacaoLaudo> NotificacaoLaudos { get; set; } = new List<NotificacaoLaudo>();

    [ForeignKey("TermoApreensaoAmostraAnaliseId")]
    [InverseProperty("Laudos")]
    public virtual TermoApreensaoAmostraAnalise? TermoApreensaoAmostraAnalise { get; set; }

    [ForeignKey("TermoVisitaSanitariaId")]
    [InverseProperty("Laudos")]
    public virtual TermoVisitaSanitarium? TermoVisitaSanitaria { get; set; }
}

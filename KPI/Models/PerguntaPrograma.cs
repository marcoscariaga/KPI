using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("PerguntaPrograma")]
[Index("Enunciado", Name = "UQ__Pergunta__8E4302B47E77B618", IsUnique = true)]
public partial class PerguntaPrograma
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Enunciado { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Gabarito { get; set; }

    public bool Ativo { get; set; }

    public bool? AnexarDocumento { get; set; }

    public int TipoRespostaId { get; set; }

    public int AssuntoId { get; set; }

    [ForeignKey("AssuntoId")]
    [InverseProperty("PerguntaProgramas")]
    public virtual AssuntoPrograma Assunto { get; set; } = null!;
}

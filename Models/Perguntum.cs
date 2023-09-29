using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("AssuntoId", Name = "IX_Pergunta_AssuntoId")]
[Index("Enunciado", Name = "UQ__Pergunta__8E4302B4373B3228", IsUnique = true)]
public partial class Perguntum
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Enunciado da pergunta
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string Enunciado { get; set; } = null!;

    /// <summary>
    /// Descrição
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// Gabarito
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Gabarito { get; set; }

    /// <summary>
    /// Ativo
    /// </summary>
    public bool Ativo { get; set; }

    /// <summary>
    /// Anexar Documento
    /// </summary>
    public bool? AnexarDocumento { get; set; }

    /// <summary>
    /// 1-Texto  2-Sim Não Não se aplica  3-Sim/Não/Não se Aplica - Com Anexo  4-Númerico
    /// </summary>
    public int TipoRespostaId { get; set; }

    /// <summary>
    /// Código do assunto
    /// </summary>
    public int AssuntoId { get; set; }

    /// <summary>
    /// Código da legislação
    /// </summary>
    public int? LegislacaoId { get; set; }

    [ForeignKey("AssuntoId")]
    [InverseProperty("Pergunta")]
    public virtual Assunto Assunto { get; set; } = null!;
}

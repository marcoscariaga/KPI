using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Assunto")]
[Index("Nome", Name = "UQ__Assunto__7D8FE3B26DCC4D03", IsUnique = true)]
public partial class Assunto
{
    /// <summary>
    /// Código que identifica o assunto
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Nome do assunto
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    /// <summary>
    /// Descrição do assunto
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// Código que identifica o segmento do assunto
    /// </summary>
    public int SegmentoId { get; set; }

    [InverseProperty("Assunto")]
    public virtual ICollection<Perguntum> Pergunta { get; set; } = new List<Perguntum>();
}

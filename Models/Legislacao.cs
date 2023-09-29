using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Legislacao")]
[Index("AscendenciaId", Name = "IX_Legislacao_AscendenciaId")]
[Index("Nome", "AscendenciaId", Name = "UQ__Legislac__07D907D1214BF109", IsUnique = true)]
public partial class Legislacao
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Nome da lei
    /// </summary>
    [StringLength(250)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    /// <summary>
    /// True-ativa  False-inativa
    /// </summary>
    public bool Ativa { get; set; }

    /// <summary>
    /// Data da desativação
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataDesativacao { get; set; }

    /// <summary>
    /// Ascendente
    /// </summary>
    public int? AscendenciaId { get; set; }

    [ForeignKey("AscendenciaId")]
    [InverseProperty("InverseAscendencia")]
    public virtual Legislacao? Ascendencia { get; set; }

    [InverseProperty("Legislacao")]
    public virtual CapitulacaoLegalInspecao? CapitulacaoLegalInspecao { get; set; }

    [InverseProperty("Ascendencia")]
    public virtual ICollection<Legislacao> InverseAscendencia { get; set; } = new List<Legislacao>();
}

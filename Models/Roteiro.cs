using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Roteiro")]
[Index("ModeloId", Name = "IX_Roteiro_ModeloId")]
[Index("Nome", Name = "UQ__Roteiro__7D8FE3B252E34C9D", IsUnique = true)]
public partial class Roteiro
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Nome
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    /// <summary>
    /// Código do modelo
    /// </summary>
    public int ModeloId { get; set; }

    [InverseProperty("Roteiro")]
    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    [ForeignKey("ModeloId")]
    [InverseProperty("Roteiros")]
    public virtual ModeloRoteiro Modelo { get; set; } = null!;

    [InverseProperty("RoteiroLicenciamento")]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    [InverseProperty("Roteiro")]
    public virtual ICollection<TipoAutorizacaoSanitarium> TipoAutorizacaoSanitaria { get; set; } = new List<TipoAutorizacaoSanitarium>();

    [InverseProperty("Roteiro")]
    public virtual ICollection<TipoPublicoAlvoRoteiro> TipoPublicoAlvoRoteiros { get; set; } = new List<TipoPublicoAlvoRoteiro>();

    [InverseProperty("Roteiro")]
    public virtual ICollection<TipoVeiculo> TipoVeiculos { get; set; } = new List<TipoVeiculo>();
}

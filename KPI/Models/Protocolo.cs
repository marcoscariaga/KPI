using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Protocolo")]
[Index("Ano", "TipoNumeracaoSicopId", Name = "UQ__Protocol__59E0F9E53DE82FB7", IsUnique = true)]
public partial class Protocolo
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Ano base
    /// </summary>
    public int Ano { get; set; }

    /// <summary>
    /// Faixa inicial
    /// </summary>
    public int FaixaInicial { get; set; }

    /// <summary>
    /// Faixa final
    /// </summary>
    public int FaixaFinal { get; set; }

    /// <summary>
    /// 1-Outros Processos  9-AutoDeclaração
    /// </summary>
    public int TipoNumeracaoSicopId { get; set; }

    /// <summary>
    /// Último número utilizado
    /// </summary>
    public int UltimoNumeroUtilizado { get; set; }

    [InverseProperty("Protocolo")]
    public virtual ICollection<NumeroSicop> NumeroSicops { get; set; } = new List<NumeroSicop>();
}

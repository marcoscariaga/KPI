using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("NumeroSicop")]
[Index("JustificativaId", Name = "IX_NumeroSicop_JustificativaId")]
[Index("ProtocoloId", Name = "IX_NumeroSicop_ProtocoloId")]
[Index("Numero", Name = "UQ__NumeroSi__7E532BC6308E3499", IsUnique = true)]
public partial class NumeroSicop
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Número
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    /// <summary>
    /// Matrícula
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    /// <summary>
    /// Login de rede
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string LoginDeRede { get; set; } = null!;

    /// <summary>
    /// Data da geração do número
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime Data { get; set; }

    /// <summary>
    /// Código da tabela de protocolo
    /// </summary>
    public int ProtocoloId { get; set; }

    /// <summary>
    /// Código da tabela de justificativa
    /// </summary>
    public int JustificativaId { get; set; }

    [ForeignKey("JustificativaId")]
    [InverseProperty("NumeroSicops")]
    public virtual Justificativa Justificativa { get; set; } = null!;

    [ForeignKey("ProtocoloId")]
    [InverseProperty("NumeroSicops")]
    public virtual Protocolo Protocolo { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AnexoAcaoSisvisa")]
public partial class AnexoAcaoSisvisa
{
    [Key]
    public int Id { get; set; }

    public int TipoDocumentoId { get; set; }

    public int SituacaoDocumentoId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroOs { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataVencimento { get; set; }

    [StringLength(516)]
    [Unicode(false)]
    public string ArquivoAnexado { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    public int AcaoSisvisaId { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    [InverseProperty("AnexoAcaoSisvisas")]
    public virtual AcaoSisvisa AcaoSisvisa { get; set; } = null!;
}

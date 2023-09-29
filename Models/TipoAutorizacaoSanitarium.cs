using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("TipoRequerimentoId", "TipoEmpresaCarroPipaId", Name = "UQ__TipoAuto__702334AB48DABF76", IsUnique = true)]
public partial class TipoAutorizacaoSanitarium
{
    [Key]
    public int Id { get; set; }

    public int TipoRequerimentoId { get; set; }

    public int RoteiroId { get; set; }

    public int TipoEmpresaCarroPipaId { get; set; }

    [ForeignKey("RoteiroId")]
    [InverseProperty("TipoAutorizacaoSanitaria")]
    public virtual Roteiro Roteiro { get; set; } = null!;
}

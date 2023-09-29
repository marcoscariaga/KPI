using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("LicencaCanceladaPorRequerente")]
public partial class LicencaCanceladaPorRequerente
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProtocoloCancelado { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ProtocoloCancelamento { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCancelamento { get; set; }

    public int? IdEstabelecimento { get; set; }

    public int? JustificativaId { get; set; }

    public int? BancaJornalId { get; set; }

    public int? FeiranteId { get; set; }

    public int? AmbulanteId { get; set; }

    [ForeignKey("AmbulanteId")]
    [InverseProperty("LicencaCanceladaPorRequerentes")]
    public virtual Ambulante? Ambulante { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class ComplementoDeInformaco
{
    [Key]
    public int Id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string Questao { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? Resposta { get; set; }

    public int SituacaoId { get; set; }

    public int? RequerimentoAdmId { get; set; }

    [ForeignKey("RequerimentoAdmId")]
    [InverseProperty("ComplementoDeInformacos")]
    public virtual RequerimentoAdministrativo? RequerimentoAdm { get; set; }
}

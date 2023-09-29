using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class LogDeCandidatoMultum
{
    [Key]
    public int Id { get; set; }

    public int? InscricaoMunicipal { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfCnpj { get; set; }

    public int? Situacao { get; set; }

    public int? Tipo { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Data { get; set; }
}

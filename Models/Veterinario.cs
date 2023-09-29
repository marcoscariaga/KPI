using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Veterinario")]
public partial class Veterinario
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeDoVeterinario { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Crmv { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string Cpf { get; set; } = null!;
}

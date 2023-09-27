using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Municipio")]
public partial class Municipio
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeMunicipio { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SiglaUf { get; set; } = null!;
}

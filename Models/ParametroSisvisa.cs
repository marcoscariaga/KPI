using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ParametroSisvisa")]
[Index("Chave", Name = "UQ__Parametr__97A44D7775C27486", IsUnique = true)]
public partial class ParametroSisvisa
{
    [Key]
    public int Id { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Chave { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Valor { get; set; } = null!;

    public int TipoId { get; set; }
}

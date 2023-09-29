using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TipoTermoLicenciamento")]
public partial class TipoTermoLicenciamento
{
    [Key]
    public int Id { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [InverseProperty("TipoTermoLicenciamento")]
    public virtual ICollection<TermoResponsabilidade> TermoResponsabilidades { get; set; } = new List<TermoResponsabilidade>();
}

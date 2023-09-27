using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("Descricao", Name = "UQ__NaoConfo__008BA9EF347EC10E", IsUnique = true)]
public partial class NaoConformidadePadronizadum
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public bool AtribuirParaTi { get; set; }

    public bool AtribuirParaAcaoSisvisa { get; set; }

    [InverseProperty("NaoConformidadePadronizada")]
    public virtual ICollection<AcaoSisvisaNaoConformidadePadronizadum> AcaoSisvisaNaoConformidadePadronizada { get; set; } = new List<AcaoSisvisaNaoConformidadePadronizadum>();
}

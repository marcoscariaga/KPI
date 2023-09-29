using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TipoDeLicenciamento")]
public partial class TipoDeLicenciamento
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NomeTipoLicenciamento { get; set; } = null!;

    [InverseProperty("IdTipoDeLicenciamentoNavigation")]
    public virtual ICollection<Multum> Multa { get; set; } = new List<Multum>();

    [InverseProperty("TipoDeLicenciamento")]
    public virtual ICollection<ProdutoBancaJornal> ProdutoBancaJornals { get; set; } = new List<ProdutoBancaJornal>();

    [InverseProperty("TipoDeLicenciamento")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();
}

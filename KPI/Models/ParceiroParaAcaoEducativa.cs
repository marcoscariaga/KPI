using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ParceiroParaAcaoEducativa")]
[Index("Cnpj", Name = "UQ__Parceiro__A299CC926A90B8FC", IsUnique = true)]
public partial class ParceiroParaAcaoEducativa
{
    [Key]
    public int Id { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string Cnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Endereco { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string NomeRepresentante { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TelefoneDeContato { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    public bool Ativo { get; set; }

    public int SegmentoDeNegocioId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataDaInclusao { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MatriculaServidor { get; set; } = null!;

    [InverseProperty("ParceiroParaAcaoEducativa")]
    public virtual ICollection<AcaoEducativaRealizadum> AcaoEducativaRealizada { get; set; } = new List<AcaoEducativaRealizadum>();
}

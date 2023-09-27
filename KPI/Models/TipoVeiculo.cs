using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TipoVeiculo")]
public partial class TipoVeiculo
{
    [Key]
    public int Id { get; set; }

    public int SegmentoId { get; set; }

    public int? ClasseId { get; set; }

    public int TipoDeVeiculoId { get; set; }

    public int? RoteiroId { get; set; }

    public int? FinalidadeId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Nome { get; set; }

    public bool? Ativo { get; set; }

    [ForeignKey("RoteiroId")]
    [InverseProperty("TipoVeiculos")]
    public virtual Roteiro? Roteiro { get; set; }

    [InverseProperty("TipoVeiculo")]
    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}

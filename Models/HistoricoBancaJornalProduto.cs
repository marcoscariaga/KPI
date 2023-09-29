using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoBancaJornalProduto")]
public partial class HistoricoBancaJornalProduto
{
    [Key]
    public int Id { get; set; }

    public int? IdBancaProdutoBancaJornal { get; set; }

    public int? IdProdutoBancaJornal { get; set; }

    public int? IdBancaJornal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataHistorico { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UsuarioAlteracao { get; set; }
}

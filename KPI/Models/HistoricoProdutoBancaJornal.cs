using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoProdutoBancaJornal")]
public partial class HistoricoProdutoBancaJornal
{
    [Key]
    public int Id { get; set; }

    public int? IdProdutoBancaJornal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nome { get; set; }

    public int? SegmentoId { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    public bool? Ativo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataHistorico { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MotivoAlteracao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UsuarioAlteracao { get; set; }
}

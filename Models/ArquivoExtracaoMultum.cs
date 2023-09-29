using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class ArquivoExtracaoMultum
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeArquivo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataExtracao { get; set; }

    public int? IdArquivoPostagem { get; set; }

    [ForeignKey("IdArquivoPostagem")]
    [InverseProperty("ArquivoExtracaoMulta")]
    public virtual ArquivoPostagemMultum? IdArquivoPostagemNavigation { get; set; }

    [InverseProperty("IdArquivoExtracaoNavigation")]
    public virtual ICollection<Multum> Multa { get; set; } = new List<Multum>();
}

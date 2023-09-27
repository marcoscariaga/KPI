using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class ArquivoPostagemMultum
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataGeracao { get; set; }

    [InverseProperty("IdArquivoPostagemNavigation")]
    public virtual ICollection<ArquivoExtracaoMultum> ArquivoExtracaoMulta { get; set; } = new List<ArquivoExtracaoMultum>();
}

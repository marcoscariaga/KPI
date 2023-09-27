using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class ArquivoMultum
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NomeDoArquivo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string UsuarioEmissorMulta { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataGeracaoArquivo { get; set; }

    public int Situacao { get; set; }

    public int IdArquivoSubstituto { get; set; }

    [InverseProperty("IdArquivoMultaNavigation")]
    public virtual ICollection<ServidoArquivoMultum> ServidoArquivoMulta { get; set; } = new List<ServidoArquivoMultum>();
}

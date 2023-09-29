using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AssuntoPrograma")]
[Index("Nome", Name = "UQ__AssuntoP__7D8FE3B24FBCC72F", IsUnique = true)]
public partial class AssuntoPrograma
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public int SegmentoId { get; set; }

    [InverseProperty("Assunto")]
    public virtual ICollection<PerguntaPrograma> PerguntaProgramas { get; set; } = new List<PerguntaPrograma>();
}

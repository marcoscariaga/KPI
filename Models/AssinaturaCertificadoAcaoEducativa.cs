using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AssinaturaCertificadoAcaoEducativa")]
[Index("Descricao", Name = "UQ__Assinatu__008BA9EF1C281490", IsUnique = true)]
public partial class AssinaturaCertificadoAcaoEducativa
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string AnexoAssinatura { get; set; } = null!;

    [InverseProperty("AssinaturaCertificadoAcaoEducativa")]
    public virtual ICollection<CursoParaAcaoEducativa> CursoParaAcaoEducativas { get; set; } = new List<CursoParaAcaoEducativa>();
}

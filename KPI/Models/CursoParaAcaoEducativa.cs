using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("CursoParaAcaoEducativa")]
[Index("Descricao", Name = "UQ__CursoPar__008BA9EF76F68FE1", IsUnique = true)]
public partial class CursoParaAcaoEducativa
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public int ModalidadeId { get; set; }

    public int CargaHoraria { get; set; }

    public int SegmentoDeNegocioId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Objetivo { get; set; } = null!;

    public string Ementa { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MatriculaServidor { get; set; } = null!;

    public int AssinaturaCertificadoAcaoEducativaId { get; set; }

    [InverseProperty("CursoParaAcaoEducativa")]
    public virtual ICollection<AcaoEducativaRealizadum> AcaoEducativaRealizada { get; set; } = new List<AcaoEducativaRealizadum>();

    [ForeignKey("AssinaturaCertificadoAcaoEducativaId")]
    [InverseProperty("CursoParaAcaoEducativas")]
    public virtual AssinaturaCertificadoAcaoEducativa AssinaturaCertificadoAcaoEducativa { get; set; } = null!;
}

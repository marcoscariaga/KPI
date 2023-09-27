using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("NumeroSisvisa", Name = "AK_NumeroSisvisa")]
[Index("NumeroSisvisa", Name = "UQ__AcaoEduc__31CEF0924A58F394", IsUnique = true)]
public partial class AcaoEducativaO
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroSisvisa { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataAcaoEducativa { get; set; }

    public int TipoId { get; set; }

    public int ConteudoAbordadoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? OutrosConteudosAbordado { get; set; }

    public int FaixaTotalProfissionaisEnvolvidosId { get; set; }

    public int TotalProfissionaisNaEmpresa { get; set; }

    public int SituacaoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Anexo { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    public bool Alimentos { get; set; }

    public bool Saude { get; set; }

    public bool Zoonoses { get; set; }

    public int ServidorQueLavrouId { get; set; }

    public int? ServidorQueAtualizouId { get; set; }

    public int TarefaId { get; set; }

    public bool GeradoAplicativoMovel { get; set; }

    public bool ValidarSisvisa { get; set; }

    [ForeignKey("ServidorQueAtualizouId")]
    [InverseProperty("AcaoEducativaOServidorQueAtualizous")]
    public virtual Servidor? ServidorQueAtualizou { get; set; }

    [ForeignKey("ServidorQueLavrouId")]
    [InverseProperty("AcaoEducativaOServidorQueLavrous")]
    public virtual Servidor ServidorQueLavrou { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("AcaoEducativaOs")]
    public virtual Tarefa Tarefa { get; set; } = null!;
}

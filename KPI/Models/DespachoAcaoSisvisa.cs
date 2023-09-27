using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("DespachoAcaoSisvisa")]
public partial class DespachoAcaoSisvisa
{
    [Key]
    public int Id { get; set; }

    public int TipoDespachoId { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string Despacho { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string Login { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    public int AcaoSisvisaId { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    [InverseProperty("DespachoAcaoSisvisas")]
    public virtual AcaoSisvisa AcaoSisvisa { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("MensagemSisvisa")]
public partial class MensagemSisvisa
{
    [Key]
    public int Id { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string TextoMensagem { get; set; } = null!;

    public bool Ativo { get; set; }

    public int? ServidorId { get; set; }

    [ForeignKey("ServidorId")]
    [InverseProperty("MensagemSisvisas")]
    public virtual Servidor? Servidor { get; set; }
}

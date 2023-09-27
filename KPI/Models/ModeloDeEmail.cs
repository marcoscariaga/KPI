using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ModeloDeEmail")]
public partial class ModeloDeEmail
{
    [StringLength(150)]
    [Unicode(false)]
    public string EmailRemetente { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Assunto { get; set; } = null!;

    [StringLength(1500)]
    [Unicode(false)]
    public string Mensagem { get; set; } = null!;

    [Key]
    public int TipoDeEmail { get; set; }
}

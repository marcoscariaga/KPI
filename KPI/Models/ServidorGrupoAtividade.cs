using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("ServidorGrupoAtividade")]
public partial class ServidorGrupoAtividade
{
    public int ServidorId { get; set; }

    public int GrupoAtividadeId { get; set; }

    [ForeignKey("GrupoAtividadeId")]
    public virtual GrupoAtividade GrupoAtividade { get; set; } = null!;

    [ForeignKey("ServidorId")]
    public virtual Servidor Servidor { get; set; } = null!;
}

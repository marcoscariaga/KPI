using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("GenerosAlimenticiosDoVeiculo")]
public partial class GenerosAlimenticiosDoVeiculo
{
    public int VeiculoId { get; set; }

    public int GeneroAlimenticioId { get; set; }

    [ForeignKey("VeiculoId")]
    public virtual Veiculo Veiculo { get; set; } = null!;
}

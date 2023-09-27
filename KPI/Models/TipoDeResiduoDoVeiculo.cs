using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("TipoDeResiduoDoVeiculo")]
public partial class TipoDeResiduoDoVeiculo
{
    public int VeiculoId { get; set; }

    public int TipoDeResiduoId { get; set; }
}

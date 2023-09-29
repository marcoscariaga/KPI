using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("FinalidadesDoVeiculo")]
public partial class FinalidadesDoVeiculo
{
    public int VeiculoId { get; set; }

    public int FinalidadeId { get; set; }
}

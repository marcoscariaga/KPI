using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TiposDeServicoDoVeiculo")]
public partial class TiposDeServicoDoVeiculo
{
    [Key]
    public int VeiculoId { get; set; }

    public int TipoDeServicoId { get; set; }
}

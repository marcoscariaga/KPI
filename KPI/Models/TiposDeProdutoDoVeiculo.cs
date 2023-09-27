using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("TiposDeProdutoDoVeiculo")]
public partial class TiposDeProdutoDoVeiculo
{
    public int VeiculoId { get; set; }

    public int TipoDeProdutoId { get; set; }
}

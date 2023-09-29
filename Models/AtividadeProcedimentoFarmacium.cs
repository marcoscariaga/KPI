using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class AtividadeProcedimentoFarmacium
{
    [Key]
    public int Id { get; set; }

    public int CodigoDaAtividade { get; set; }

    public int CodigoProcedimentoFarmacia { get; set; }

    public int IdEstabelecimento { get; set; }

    public bool? Ativo { get; set; }
}

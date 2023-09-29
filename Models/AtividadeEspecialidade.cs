using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AtividadeEspecialidade")]
public partial class AtividadeEspecialidade
{
    [Key]
    public int Id { get; set; }

    public int CodigoDaAtividade { get; set; }

    public int CodigoEspecialidadeClinica { get; set; }

    public int IdEstabelecimento { get; set; }

    public bool? Ativo { get; set; }
}

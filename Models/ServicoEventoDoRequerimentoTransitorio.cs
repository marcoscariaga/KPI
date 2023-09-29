using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ServicoEventoDoRequerimentoTransitorio")]
public partial class ServicoEventoDoRequerimentoTransitorio
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    public int CodigoDoTipoServicoEvento { get; set; }
}

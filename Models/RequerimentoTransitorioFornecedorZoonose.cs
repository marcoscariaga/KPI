using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoTransitorioFornecedorZoonose")]
public partial class RequerimentoTransitorioFornecedorZoonose
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    public bool ComprovanteDeVacina { get; set; }

    public bool ComprovanteSanidadeMental { get; set; }

    public bool ComprovanteDeControle { get; set; }
}

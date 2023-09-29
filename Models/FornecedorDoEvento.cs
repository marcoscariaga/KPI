using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("FornecedorDoEvento")]
public partial class FornecedorDoEvento
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Endereco { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? InscricaoMunicipal { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    public int EnergiaEletrica { get; set; }

    public int AguaAbastecimento { get; set; }

    public int Exaustao { get; set; }

    public int Atividade { get; set; }
}

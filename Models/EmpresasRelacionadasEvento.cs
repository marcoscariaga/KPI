using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("EmpresasRelacionadasEvento")]
public partial class EmpresasRelacionadasEvento
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string InscricaoMunicipal { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefone { get; set; }

    public int QuantidadeDePontoDeAlimentacao { get; set; }

    public int QuantidadeDePontoMedico { get; set; }

    public int QuantidadeDeAmbulanciaD { get; set; }

    public int QuantidadeDeAmbulanciaB { get; set; }

    public int TipoDeEmpresa { get; set; }

    public int? CodigoDaAtividade { get; set; }

    public int? CodigoDoServico { get; set; }
}

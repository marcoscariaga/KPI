using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Evento")]
[Index("Id", Name = "Evento_Id_uindex", IsUnique = true)]
public partial class Evento
{
    [Column("CPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Cpe { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NomeRequerente { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("CNPJ")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Cnpj { get; set; }

    [Column("CPF")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Cpf { get; set; }

    [Column("RG")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Rg { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? InscMunicipal { get; set; }

    [StringLength(288)]
    [Unicode(false)]
    public string? EnderecoRequerente { get; set; }

    [Column("ResidenteRJ")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ResidenteRj { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DataSolicitacao { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DataEvento { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? AlvaraLiberado { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NomeEvento { get; set; }

    [StringLength(287)]
    [Unicode(false)]
    public string? EnderecoEvento { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? DescricaoEvento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicioEvento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFimEvento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicioMontagem { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFimMontagem { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AreaPublica { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AreaPrivada { get; set; }

    [Column(TypeName = "numeric(19, 2)")]
    public decimal? AreaOcupada { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? FechamentoRua { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? AlteracaoLocal { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? EstimativaPublico { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Publicidade { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? HaveraFogos { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? EmpresaSeguranca { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AbertoPublico { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? CobrancaIngresso { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Estrutura { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? ManipulacaoAlimento { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? Filmagem { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? ReservaVagas { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? EventoOrlaJardim { get; set; }

    [Key]
    public int Id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? CodLogEvento { get; set; }

    [Column("CEPEvento")]
    [StringLength(9)]
    [Unicode(false)]
    public string? Cepevento { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? CodLogRequerente { get; set; }

    [Column("CEPRequerente")]
    [StringLength(9)]
    [Unicode(false)]
    public string? Ceprequerente { get; set; }
}

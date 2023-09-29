using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Atividade")]
[Index("RoteiroId", Name = "IX_Atividade_RoteiroId")]
[Index("Codigo", Name = "gqs_carga_1")]
public partial class Atividade
{
    /// <summary>
    /// Código que identifica a atividade
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Código da atividade no SINAE
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    /// <summary>
    /// Descrição da atividade
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// identifica a atividade que pode ser referenciada no SISVISA.  Valores: [Sim/Não]
    /// </summary>
    public bool Ativo { get; set; }

    /// <summary>
    /// identifica a atividade que obriga a identificação de um responsável técnico. Valores: [Sim/Não]
    /// </summary>
    public bool ExigeResponsavelTecnico { get; set; }

    /// <summary>
    /// Código que identifica o risco da atividade. Valores: [1-Baixo/2-Médio/3-Alto]
    /// </summary>
    public int RiscoId { get; set; }

    /// <summary>
    /// Código que identifica o segmento da atividade. Valores: [1-Comum/2-Alimento/3-Engenharia/4-Saúde/5-Zoonose]
    /// </summary>
    public int SegmentoId { get; set; }

    /// <summary>
    /// Código que identifica o licenciamento da atividade. Valores: [1-AutoDeclaração/2-Simplificado/3-Tradicional]
    /// </summary>
    public int LicenciamentoId { get; set; }

    /// <summary>
    /// Código de identifica o roteiro da atividade
    /// </summary>
    public int? RoteiroId { get; set; }

    public bool ServicoAmbulanciaDistribuidora { get; set; }

    public bool NecessitaComplemento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ComplementoAtividade { get; set; }

    public bool Mei { get; set; }

    [Column("complexidade")]
    public int? Complexidade { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Fator { get; set; }

    public bool? Inspecao { get; set; }

    public bool? Asp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DtCadastro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DtAtualizacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DtDaValidadeDaLicenca { get; set; }

    public bool? Verificada { get; set; }

    [Column(TypeName = "numeric(4, 2)")]
    public decimal? FatorMultiplicador { get; set; }

    public int? Grupo { get; set; }

    public bool? Regulada { get; set; }

    public int QuantidadeVeiculos { get; set; }

    public bool TerceirizaVeiculo { get; set; }

    public bool Internacao { get; set; }

    public bool ComInternacao { get; set; }

    public bool EspecialidadeMedica { get; set; }

    public bool Afe { get; set; }

    public int? ProcedimentoFarmacia { get; set; }

    public int? ProcedimentoInvasivo { get; set; }

    public bool? Supermercado { get; set; }

    public bool SupermercadoOpcional { get; set; }

    public bool SupermercadoObrigatorio { get; set; }

    public bool Repa { get; set; }

    public bool Industria { get; set; }

    public bool Autosservico { get; set; }

    public byte? TipoDeAtividade { get; set; }

    [Column("ComplexidadeREPA")]
    public int? ComplexidadeRepa { get; set; }

    [Column("RiscoREPA")]
    public int? RiscoRepa { get; set; }

    public bool RealizaAbate { get; set; }

    public bool TipoSegmentoFarmaciaManipulacao { get; set; }

    public int? ComplexidadeParaAbate { get; set; }

    public int? RiscoParaAbate { get; set; }

    public int? TipoDeAtividadeParaAbate { get; set; }

    [InverseProperty("Atividade")]
    public virtual ICollection<AtividadeAmbulante> AtividadeAmbulantes { get; set; } = new List<AtividadeAmbulante>();

    [InverseProperty("Atividade")]
    public virtual ICollection<AtividadeFeirante> AtividadeFeirantes { get; set; } = new List<AtividadeFeirante>();

    [InverseProperty("Atividade")]
    public virtual ICollection<AtividadeSecundarium> AtividadeSecundaria { get; set; } = new List<AtividadeSecundarium>();

    [InverseProperty("Atividade")]
    public virtual ICollection<HistoricoAtividadeAmbulante> HistoricoAtividadeAmbulantes { get; set; } = new List<HistoricoAtividadeAmbulante>();

    [InverseProperty("Atividade")]
    public virtual ICollection<HistoricoAtividadeFeirante> HistoricoAtividadeFeirantes { get; set; } = new List<HistoricoAtividadeFeirante>();

    [InverseProperty("Atividade")]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    [ForeignKey("RoteiroId")]
    [InverseProperty("Atividades")]
    public virtual Roteiro? Roteiro { get; set; }
}

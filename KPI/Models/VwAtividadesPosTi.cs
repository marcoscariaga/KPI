using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwAtividadesPosTi
{
    public int Id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public bool Ativo { get; set; }

    public bool ExigeResponsavelTecnico { get; set; }

    public int RiscoId { get; set; }

    public int SegmentoId { get; set; }

    public int LicenciamentoId { get; set; }

    public int? RoteiroId { get; set; }

    public bool ServicoAmbulanciaDistribuidora { get; set; }

    public bool NecessitaComplemento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ComplementoAtividade { get; set; }

    public bool Mei { get; set; }

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
}

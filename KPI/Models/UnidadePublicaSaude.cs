using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("UnidadePublicaSaude")]
[Index("Cnpj", Name = "UQ__UnidadeP__0BCA032A3B2BBE9D", IsUnique = true)]
[Index("RazaoSocial", Name = "UQ__UnidadeP__448779F02097C3F2", IsUnique = true)]
public partial class UnidadePublicaSaude
{
    [Key]
    public int Id { get; set; }

    public int TipoPublicoAlvoId { get; set; }

    public int TipoGestaoUnidadePublicaId { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? NumeroCnes { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string Cnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string NomeDeContato { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TelefoneDeContato { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataDaInclusao { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeRt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CpfRt { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ProfissaoRt { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? EmailRt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TelefoneDeContatoRt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Telefone2Rt { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AnexoIdentificacaoRt { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AnexoVinculoResponsabilidadeRt { get; set; }

    public int? SituacaoDocumentoRtId { get; set; }

    public int? SituacaoCadastroRtId { get; set; }

    [Column(TypeName = "decimal(9, 7)")]
    public decimal Latitude { get; set; }

    [Column(TypeName = "decimal(9, 7)")]
    public decimal Longitude { get; set; }

    public int SegmentoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Ra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BairroDaLocalizacao { get; set; }

    public bool PreenchidoPeloServico { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Logradouro { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Cidade { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    public int CepNumero { get; set; }

    public short CepComplemento { get; set; }

    public string? Observacao { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroProcesso { get; set; }

    [InverseProperty("UnidadePublicaSaude")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [InverseProperty("UnidadePublicaSaude")]
    public virtual ICollection<HistoricoInspecao> HistoricoInspecaos { get; set; } = new List<HistoricoInspecao>();
}

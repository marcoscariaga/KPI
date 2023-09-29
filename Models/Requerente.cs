using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Requerente")]
[Index("CpfCnpj", Name = "IX_Requerente_CpfCnpj")]
[Index("CpfCnpj", Name = "UQ__Requeren__0BCA032A01342732", IsUnique = true)]
public partial class Requerente
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeFantasia { get; set; }

    public bool Ativo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeArquivo { get; set; }

    public int TipoDocumentoDoRequerenteId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NumeroDocumentoIdentificacao { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string OrgaoExpedidorDocumento { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataExpedicaoDocumento { get; set; }

    public int TipoRequerenteId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TelefoneDeContato { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    public int SituacaoCadastroId { get; set; }

    public int SegmentoId { get; set; }

    public int? JustificativaId { get; set; }

    public int? RequerimentoAdmId { get; set; }

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

    [InverseProperty("Requerente")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [InverseProperty("Requerente")]
    public virtual ICollection<AutorizacaoSanitarium> AutorizacaoSanitaria { get; set; } = new List<AutorizacaoSanitarium>();

    [InverseProperty("Requerente")]
    public virtual ICollection<HistoricoInspecao> HistoricoInspecaos { get; set; } = new List<HistoricoInspecao>();

    [ForeignKey("JustificativaId")]
    [InverseProperty("Requerentes")]
    public virtual Justificativa? Justificativa { get; set; }

    [InverseProperty("Requerente")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();

    [ForeignKey("RequerimentoAdmId")]
    [InverseProperty("Requerentes")]
    public virtual RequerimentoAdministrativo? RequerimentoAdm { get; set; }

    [InverseProperty("Requerente")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [InverseProperty("Requerente")]
    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}

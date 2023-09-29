using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("PontoColetaVigiagua")]
[Index("NomeLocal", Name = "UQ__PontoCol__C6ECE72707420643", IsUnique = true)]
public partial class PontoColetaVigiagua
{
    [Key]
    public int Id { get; set; }

    public int TipoPublicoAlvoId { get; set; }

    public int SistemaVigiAguaId { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? Cnpj { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string NomeLocal { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataDaInclusao { get; set; }

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

    [StringLength(4)]
    [Unicode(false)]
    public string? Amostra { get; set; }

    [InverseProperty("PontoColetaVigiagua")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();
}

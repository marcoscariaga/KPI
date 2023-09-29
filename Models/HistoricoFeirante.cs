using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoFeirante")]
public partial class HistoricoFeirante
{
    [Key]
    public int Id { get; set; }

    public int? FeiranteId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string InscricaoMunicipal { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TipoPessoa { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfCnpj { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefone { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? SituacaoDoAlvara { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NumeroPorta { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Cep { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Municipio { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Uf { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    public bool Mei { get; set; }

    public bool PequenosAgricultores { get; set; }

    public bool AgricultoresFamiliares { get; set; }

    public bool ProdutoresAgroecologicos { get; set; }

    public bool ProdutoresQuilombolas { get; set; }

    [ForeignKey("FeiranteId")]
    [InverseProperty("HistoricoFeirantes")]
    public virtual Feirante? Feirante { get; set; }

    [InverseProperty("HistoricoFeirante")]
    public virtual ICollection<HistoricoAtividadeFeirante> HistoricoAtividadeFeirantes { get; set; } = new List<HistoricoAtividadeFeirante>();

    [InverseProperty("HistoricoFeirante")]
    public virtual ICollection<HistoricoFeiranteFeira> HistoricoFeiranteFeiras { get; set; } = new List<HistoricoFeiranteFeira>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoAmbulante")]
public partial class HistoricoAmbulante
{
    [Key]
    public int Id { get; set; }

    public int AmbulanteId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string InscricaoMunicipal { get; set; } = null!;

    [Column("cpfCnpj")]
    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeTitular { get; set; }

    public int AutorizacaoId { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Numero { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [Column("CEP")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Cep { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TelefoneTitular { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CelularTitular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmailTitular { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouroPonto { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? LogradouroPonto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenciaPonto { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroPonto { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ComplementoPonto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BairroPonto { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Equipamento { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? AreaUtil { get; set; }

    public bool Mei { get; set; }

    public bool PequenosAgricultores { get; set; }

    public bool AgricultoresFamiliares { get; set; }

    public bool ProdutoresAgroecologicos { get; set; }

    public bool ProdutoresQuilombolas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SituacaoDoAlvara { get; set; }

    public bool Domingo { get; set; }

    public bool Segunda { get; set; }

    public bool Terca { get; set; }

    public bool Quarta { get; set; }

    public bool Quinta { get; set; }

    public bool Sexta { get; set; }

    public bool Sabado { get; set; }

    public bool Feriados { get; set; }

    public bool Manha { get; set; }

    public bool Tarde { get; set; }

    public bool Noite { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? OutrosHorarios { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataInclusao { get; set; }

    [ForeignKey("AmbulanteId")]
    [InverseProperty("HistoricoAmbulantes")]
    public virtual Ambulante Ambulante { get; set; } = null!;

    [InverseProperty("HistoricoAmbulante")]
    public virtual ICollection<HistoricoAtividadeAmbulante> HistoricoAtividadeAmbulantes { get; set; } = new List<HistoricoAtividadeAmbulante>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("NotificacaoLaudo")]
[Index("NumeroNotificacao", Name = "AK_NumeroNotificacao")]
[Index("NumeroNotificacao", Name = "UQ__Notifica__2062F43A5689C04F", IsUnique = true)]
public partial class NotificacaoLaudo
{
    [Key]
    public int Id { get; set; }

    public int TipoNotificacaoId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string NumeroNotificacao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataNotificacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataEnvioNotificacao { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroAvisoRecebimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRecebimentoNotificacao { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Cnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string Endereco { get; set; } = null!;

    public int SituacaoNotificacaoId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MatriculaServidor { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string Ensaio { get; set; } = null!;

    public int SegmentoId { get; set; }

    public string? Acoes { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeResponsavelSegmento { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CargoResponsavelSegmento { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string MatriculaResponsavelSegmento { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NomeResponsavelSubvisa { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CargoResponsavelSubvisa { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string MatriculaResponsavelSubvisa { get; set; } = null!;

    public int LaudoId { get; set; }

    public int QuantidadeDiasPrazoDefesa { get; set; }

    public bool EnderecoNotificacaoDiferenteDaColeta { get; set; }

    [ForeignKey("LaudoId")]
    [InverseProperty("NotificacaoLaudos")]
    public virtual Laudo Laudo { get; set; } = null!;

    [InverseProperty("NotificacaoLaudo")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();
}

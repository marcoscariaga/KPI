using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TermoApreensaoAmostraAnalise")]
[Index("NumeroTermoServidor", Name = "AK_NumeroTermoServidor")]
[Index("NumeroTermoSisvisa", Name = "AK_NumeroTermoSisvisa")]
[Index("NumeroTermoServidor", Name = "UQ__TermoApr__29DD6E165C4299A5", IsUnique = true)]
[Index("NumeroTermoSisvisa", Name = "UQ__TermoApr__BA4C6526781FBE44", IsUnique = true)]
public partial class TermoApreensaoAmostraAnalise
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermoSisvisa { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermoServidor { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataHoraApreensao { get; set; }

    public int SituacaoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Anexo { get; set; } = null!;

    public bool Alimentos { get; set; }

    public bool Saude { get; set; }

    public bool Zoonoses { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string NomeRepresentanteLegal { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfRepresentanteLegal { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeResponsavelTecnico { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfResponsavelTecnico { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Produto { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Marca { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroRegistro { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string Apresentacao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataFabricacao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Validade { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LotePartida { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataHoraColetaAmostra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string QuantidadeVolumePeso { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TemperaturaProdutoNaColeta { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Umidade { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string MotivoColeta { get; set; } = null!;

    public int ModalidadeAnaliseId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? OutrosMotivoDeColeta { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Lacre1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Lacre2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Lacre3 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Observacoes { get; set; }

    public int? TermoApreensaoId { get; set; }

    public int ServidorQueLavrouId { get; set; }

    public int? ServidorQueAtualizouId { get; set; }

    public int LaboratorioId { get; set; }

    public int CapitulacaoLegalId { get; set; }

    public int TarefaId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string RazaoSocialNomeFabricante { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string CnpjFabricante { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string EnderecoFabricante { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNomeDetentorRegistro { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CnpjDetentorRegistro { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? EnderecoDetentorRegistro { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNomeDistribuidor { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CnpjDistribuidor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? EnderecoDistribuidor { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNomeImportador { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CnpjImportador { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? EnderecoImportador { get; set; }

    public bool GeradoAplicativoMovel { get; set; }

    [ForeignKey("CapitulacaoLegalId")]
    [InverseProperty("TermoApreensaoAmostraAnalises")]
    public virtual CapitulacaoLegalInspecao CapitulacaoLegal { get; set; } = null!;

    [ForeignKey("LaboratorioId")]
    [InverseProperty("TermoApreensaoAmostraAnalises")]
    public virtual Laboratorio Laboratorio { get; set; } = null!;

    [InverseProperty("TermoApreensaoAmostraAnalise")]
    public virtual ICollection<Laudo> Laudos { get; set; } = new List<Laudo>();

    [InverseProperty("TermoApreensaoAmostraAnalise")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [ForeignKey("ServidorQueAtualizouId")]
    [InverseProperty("TermoApreensaoAmostraAnaliseServidorQueAtualizous")]
    public virtual Servidor? ServidorQueAtualizou { get; set; }

    [ForeignKey("ServidorQueLavrouId")]
    [InverseProperty("TermoApreensaoAmostraAnaliseServidorQueLavrous")]
    public virtual Servidor ServidorQueLavrou { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("TermoApreensaoAmostraAnalises")]
    public virtual Tarefa Tarefa { get; set; } = null!;

    [ForeignKey("TermoApreensaoId")]
    [InverseProperty("TermoApreensaoAmostraAnalises")]
    public virtual TermoApreensao? TermoApreensao { get; set; }

    [InverseProperty("TermoApreensaoAmostraAnalise")]
    public virtual ICollection<TermoApreensao> TermoApreensaos { get; set; } = new List<TermoApreensao>();
}

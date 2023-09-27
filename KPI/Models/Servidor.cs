using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Servidor")]
[Index("Matricula", Name = "UQ__Servidor__0FB9FB4F5B78929E", IsUnique = true)]
[Index("LoginDeRede", Name = "UQ__Servidor__D31B114B5E54FF49", IsUnique = true)]
public partial class Servidor
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Login do servidor, funcionário na rede
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string LoginDeRede { get; set; } = null!;

    /// <summary>
    /// Matrícula
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    /// <summary>
    /// Nome
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? Nome { get; set; }

    /// <summary>
    /// Lugar em que está lotado
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? Lotacao { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? Email { get; set; }

    /// <summary>
    /// Ativo-true  Inativo-false
    /// </summary>
    public bool Ativo { get; set; }

    /// <summary>
    /// Cargo ou função
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? CargoFuncao { get; set; }

    /// <summary>
    /// 1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose
    /// </summary>
    public int? SegmentoId { get; set; }

    public bool Administrador { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeArquivoFotoAnexada { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroDocumentoIdentificacao { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrgaoExpedidorDocumento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataExpedicaoDocumento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Cpf { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeNascimento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TelefoneResidencial { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TelefoneCelular { get; set; }

    public int? CargoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Numero { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Cidade { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Uf { get; set; }

    public int? CepNumero { get; set; }

    public short? CepComplemento { get; set; }

    public bool? FuncaoGratificada { get; set; }

    public int? SimboloId { get; set; }

    public bool InspecionaSegmentoNegocioAlimentos { get; set; }

    public bool InspecionaSegmentoNegocioSaude { get; set; }

    public bool InspecionaSegmentoNegocioZoonoses { get; set; }

    [Column("Servidor")]
    public bool Servidor1 { get; set; }

    public bool AssinaDarmMulta { get; set; }

    [InverseProperty("ServidorQueAtualizou")]
    public virtual ICollection<AcaoEducativaO> AcaoEducativaOServidorQueAtualizous { get; set; } = new List<AcaoEducativaO>();

    [InverseProperty("ServidorQueLavrou")]
    public virtual ICollection<AcaoEducativaO> AcaoEducativaOServidorQueLavrous { get; set; } = new List<AcaoEducativaO>();

    [InverseProperty("InstrutorSubvisa")]
    public virtual ICollection<AcaoEducativaRealizadum> AcaoEducativaRealizadumInstrutorSubvisas { get; set; } = new List<AcaoEducativaRealizadum>();

    [InverseProperty("Servidor")]
    public virtual ICollection<AcaoEducativaRealizadum> AcaoEducativaRealizadumServidors { get; set; } = new List<AcaoEducativaRealizadum>();

    [ForeignKey("CargoId")]
    [InverseProperty("Servidors")]
    public virtual Cargo? Cargo { get; set; }

    [InverseProperty("ServidorQueAtualizou")]
    public virtual ICollection<EditalInterdicao> EditalInterdicaoServidorQueAtualizous { get; set; } = new List<EditalInterdicao>();

    [InverseProperty("ServidorQueLavrou")]
    public virtual ICollection<EditalInterdicao> EditalInterdicaoServidorQueLavrous { get; set; } = new List<EditalInterdicao>();

    [InverseProperty("Servidor")]
    public virtual ICollection<MensagemSisvisa> MensagemSisvisas { get; set; } = new List<MensagemSisvisa>();

    public virtual ICollection<Multum> Multa { get; set; } = new List<Multum>();

    [InverseProperty("ServidorQueAtualizou")]
    public virtual ICollection<NotificacaoInfracao> NotificacaoInfracaoServidorQueAtualizous { get; set; } = new List<NotificacaoInfracao>();

    [InverseProperty("ServidorQueLavrou")]
    public virtual ICollection<NotificacaoInfracao> NotificacaoInfracaoServidorQueLavrous { get; set; } = new List<NotificacaoInfracao>();

    public virtual ServidoArquivoMultum? ServidoArquivoMultum { get; set; }

    [InverseProperty("IdDoServidorNavigation")]
    public virtual ICollection<ServidorCertificado> ServidorCertificados { get; set; } = new List<ServidorCertificado>();

    [InverseProperty("ServidorQueAtualizou")]
    public virtual ICollection<TermoApreensaoAmostraAnalise> TermoApreensaoAmostraAnaliseServidorQueAtualizous { get; set; } = new List<TermoApreensaoAmostraAnalise>();

    [InverseProperty("ServidorQueLavrou")]
    public virtual ICollection<TermoApreensaoAmostraAnalise> TermoApreensaoAmostraAnaliseServidorQueLavrous { get; set; } = new List<TermoApreensaoAmostraAnalise>();

    [InverseProperty("ServidorQueAtualizou")]
    public virtual ICollection<TermoApreensao> TermoApreensaoServidorQueAtualizous { get; set; } = new List<TermoApreensao>();

    [InverseProperty("ServidorQueLavrou")]
    public virtual ICollection<TermoApreensao> TermoApreensaoServidorQueLavrous { get; set; } = new List<TermoApreensao>();

    [InverseProperty("ServidorQueAtualizou")]
    public virtual ICollection<TermoIntimacao> TermoIntimacaoServidorQueAtualizous { get; set; } = new List<TermoIntimacao>();

    [InverseProperty("ServidorQueLavrou")]
    public virtual ICollection<TermoIntimacao> TermoIntimacaoServidorQueLavrous { get; set; } = new List<TermoIntimacao>();

    [InverseProperty("ServidorQueAtualizou")]
    public virtual ICollection<TermoVisitaSanitarium> TermoVisitaSanitariumServidorQueAtualizous { get; set; } = new List<TermoVisitaSanitarium>();

    [InverseProperty("ServidorQueLavrou")]
    public virtual ICollection<TermoVisitaSanitarium> TermoVisitaSanitariumServidorQueLavrous { get; set; } = new List<TermoVisitaSanitarium>();
}

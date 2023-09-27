using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Justificativa")]
[Index("Nome", "TipoId", Name = "UQ__Justific__14FF7A596CF8245B", IsUnique = true)]
public partial class Justificativa
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Nome
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    /// <summary>
    /// 1-Deferimento  2-Indeferimento  3-Exigência
    /// </summary>
    public int TipoId { get; set; }

    [InverseProperty("Justificativa")]
    public virtual ICollection<Ambulante> Ambulantes { get; set; } = new List<Ambulante>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<AutorizacaoSanitarium> AutorizacaoSanitaria { get; set; } = new List<AutorizacaoSanitarium>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<Estabelecimento> Estabelecimentos { get; set; } = new List<Estabelecimento>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<EventoAmbulante> EventoAmbulantes { get; set; } = new List<EventoAmbulante>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<EventoBancaJornal> EventoBancaJornals { get; set; } = new List<EventoBancaJornal>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<EventoEstabelecimento> EventoEstabelecimentos { get; set; } = new List<EventoEstabelecimento>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<EventoFeirante> EventoFeirantes { get; set; } = new List<EventoFeirante>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<Feirante> Feirantes { get; set; } = new List<Feirante>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<NumeroSicop> NumeroSicops { get; set; } = new List<NumeroSicop>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<Requerente> Requerentes { get; set; } = new List<Requerente>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [InverseProperty("Justificativa")]
    public virtual ICollection<RequerimentoAutodeclaracao> RequerimentoAutodeclaracaos { get; set; } = new List<RequerimentoAutodeclaracao>();

    [InverseProperty("Justificatica")]
    public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
}

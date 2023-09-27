using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("DemandaProcessosOffLine")]
public partial class DemandaProcessosOffLine
{
    /// <summary>
    /// Código que identifica a demanda do processo off-line
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Login do funcionário responsável pela criação da demanda do processo off-line
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? LoginDeRede { get; set; }

    /// <summary>
    /// Matrícula do funcionário responsável pela criação da demanda do processo off-line
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Matricula { get; set; }

    /// <summary>
    /// Data em que a demanda do processo off-line foi criada
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    /// <summary>
    /// Data em que a demanda do processo off-line foi executada
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataExecucao { get; set; }

    /// <summary>
    /// Data em que a demanda do processo off-line foi concluída
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataConclusao { get; set; }

    /// <summary>
    /// Código que identifica o estabelecimento do processo off-line
    /// </summary>
    public int? IdEstabelecimento { get; set; }

    /// <summary>
    /// Código que identifica o requerimento do processo off-line
    /// </summary>
    public int? IdRequerimento { get; set; }

    /// <summary>
    /// Mensagem de retorno do serviço TIS
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? ResultadoDaOperacao { get; set; }

    /// <summary>
    /// Código que identifica o tipo de origem para o processo off-line.Valores: [1-Tis]
    /// </summary>
    public int TipoOrigemDoProcessoOffLineId { get; set; }

    /// <summary>
    /// Código que identifica o tipo de processo off-line. Valores: [1-Incluir contribuinte na TIS/ 4-Alterar área na TIS].
    /// </summary>
    public int TipoDoProcessoOffLineId { get; set; }
}

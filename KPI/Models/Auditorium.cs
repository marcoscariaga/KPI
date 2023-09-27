using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("ObjetoAuditado", Name = "IX_AuditoriaDeObjetoAuditado")]
[Index("Data", "Login", Name = "IX_AuditoriaDoLogin")]
public partial class Auditorium
{
    /// <summary>
    /// Código que identifica a auditoria
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// Código que identifica o objeto auditado
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Identificacao { get; set; } = null!;

    /// <summary>
    /// Descrição da ação auditada
    /// </summary>
    [StringLength(2000)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// Data e hora da ação realizada
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime Data { get; set; }

    /// <summary>
    /// Login do funcionário responsável pela ação realizada
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string Login { get; set; } = null!;

    /// <summary>
    /// Matrícula do funcionário responsável pela ação realizada
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    /// <summary>
    /// Código do objeto auditado. Valores: [1-Usuário/ 2- Requerimento/ 3- Legislação/ 4-Estabelecimento].
    /// </summary>
    public int ObjetoAuditado { get; set; }
}

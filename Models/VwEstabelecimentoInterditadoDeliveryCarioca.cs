using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwEstabelecimentoInterditadoDeliveryCarioca
{
    public int InscricaoMunicipal { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroTermoSisvisa { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataHoraInterdicao { get; set; }

    public int TarefaId { get; set; }

    public int TipoId { get; set; }

    public int SituacaoId { get; set; }

    public int SituacaoAlocacaoId { get; set; }
}

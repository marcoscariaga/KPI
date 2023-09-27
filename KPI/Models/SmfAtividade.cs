﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("smf_atividade")]
public partial class SmfAtividade
{
    [Column("INSCRICAOMUNICIPAL_ORIG", TypeName = "numeric(8, 0)")]
    public decimal InscricaomunicipalOrig { get; set; }

    [Column("INSCRICAOMUNICIPAL")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Inscricaomunicipal { get; set; }

    [Column("CODIGO")]
    [StringLength(6)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column("DESCRICAO")]
    [StringLength(52)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    [Column("INSCRICAO")]
    public int? Inscricao { get; set; }
}

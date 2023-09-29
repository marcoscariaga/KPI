﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("ServidorEscalaTrabalho")]
public partial class ServidorEscalaTrabalho
{
    public int ServidorId { get; set; }

    public int SegmentoId { get; set; }

    public bool Segunda { get; set; }

    public bool Terca { get; set; }

    public bool Quarta { get; set; }

    public bool Quinta { get; set; }

    public bool Sexta { get; set; }

    public bool Sabado { get; set; }

    public bool Domingo { get; set; }

    public int CargaHoraria { get; set; }

    [ForeignKey("ServidorId")]
    public virtual Servidor Servidor { get; set; } = null!;
}

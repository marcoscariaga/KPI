using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[PrimaryKey("IdArquivoMulta", "IdServidor")]
public partial class ServidorArquivoMultum
{
    [Key]
    public int IdArquivoMulta { get; set; }

    [Key]
    public int IdServidor { get; set; }
}

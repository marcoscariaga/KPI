using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("EmpresaOutorga")]
public partial class EmpresaOutorga
{
    public int Id { get; set; }

    public int InscricaoEmpresaOutorgada { get; set; }

    public int? IdEstabelecimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDaOutorga { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCancelamentoDaOutorga { get; set; }

    public int? IdHistoricoDeLicenca { get; set; }

    [ForeignKey("IdHistoricoDeLicenca")]
    public virtual HistoricoDeLicenca? IdHistoricoDeLicencaNavigation { get; set; }
}

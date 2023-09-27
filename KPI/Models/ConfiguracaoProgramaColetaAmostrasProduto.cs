using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class ConfiguracaoProgramaColetaAmostrasProduto
{
    [Key]
    public int Id { get; set; }

    public int ModalidadeAnaliseProgramaId { get; set; }

    public int TemperaturaTransporteId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Produto { get; set; } = null!;

    public int QuantidadeAmostrasMes { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string SetorAnalitico { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string QuantidadeEnvelope { get; set; } = null!;

    public int ProgramaId { get; set; }

    [InverseProperty("ConfiguracaoProgramaColetaAmostrasProdutos")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [ForeignKey("ProgramaId")]
    [InverseProperty("ConfiguracaoProgramaColetaAmostrasProdutos")]
    public virtual Programa Programa { get; set; } = null!;
}

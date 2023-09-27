using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("EstabelecimentoLicenciadoLSS")]
public partial class EstabelecimentoLicenciadoLss
{
    [Column("inscricao_municipal")]
    public int? InscricaoMunicipal { get; set; }

    [Column("protocolo_solicitacao")]
    public long? ProtocoloSolicitacao { get; set; }

    [Column("numero")]
    public long Numero { get; set; }

    [Column("data_concessao", TypeName = "datetime")]
    public DateTime DataConcessao { get; set; }

    [Column("id_status")]
    public byte? IdStatus { get; set; }

    [Column("descricao_status")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DescricaoStatus { get; set; }

    [Column("data_status", TypeName = "datetime")]
    public DateTime DataStatus { get; set; }

    [Column("id_atividade_economica")]
    [StringLength(6)]
    [Unicode(false)]
    public string? IdAtividadeEconomica { get; set; }
}

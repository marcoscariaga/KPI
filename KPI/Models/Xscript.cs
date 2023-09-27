using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("XScripts")]
public partial class Xscript
{
    [Column("host_name")]
    [StringLength(50)]
    public string? HostName { get; set; }

    [Column("login_name")]
    [StringLength(30)]
    public string? LoginName { get; set; }

    [Column("database_name")]
    [StringLength(50)]
    public string? DatabaseName { get; set; }

    [Column("statement executing")]
    public string? StatementExecuting { get; set; }

    [Column("cpu_time")]
    public int? CpuTime { get; set; }

    [Column("granted_query_memory")]
    public int? GrantedQueryMemory { get; set; }

    [Column("wait_time")]
    public int? WaitTime { get; set; }

    [Column("total_elapsed_time")]
    public int? TotalElapsedTime { get; set; }

    [Column("reads")]
    public int? Reads { get; set; }

    [StringLength(20)]
    public string? Hours { get; set; }
}

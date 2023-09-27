using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("aspnet_Users")]
[Index("ApplicationId", "LastActivityDate", Name = "aspnet_Users_Index2")]
public partial class AspnetUser
{
    public Guid ApplicationId { get; set; }

    [Key]
    public Guid UserId { get; set; }

    [StringLength(256)]
    public string UserName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredUserName { get; set; } = null!;

    [StringLength(16)]
    public string? MobileAlias { get; set; }

    public bool IsAnonymous { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastActivityDate { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("AspnetUsers")]
    public virtual AspnetApplication Application { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<AspnetRole> Roles { get; set; } = new List<AspnetRole>();
}

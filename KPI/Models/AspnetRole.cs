using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("aspnet_Roles")]
public partial class AspnetRole
{
    public Guid ApplicationId { get; set; }

    [Key]
    public Guid RoleId { get; set; }

    [StringLength(256)]
    public string RoleName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredRoleName { get; set; } = null!;

    [StringLength(256)]
    public string? Description { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("AspnetRoles")]
    public virtual AspnetApplication Application { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("Roles")]
    public virtual ICollection<AspnetUser> Users { get; set; } = new List<AspnetUser>();
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwAspnetUsersInRole
{
    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rw_fortia_prime_api.Entities;

public partial class FortiaDbContext : DbContext
{
    public FortiaDbContext()
    {
    }

    public FortiaDbContext(DbContextOptions<FortiaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<RhPuesto> RhPuestos { get; set; }
    public virtual DbSet<RhTrab> RhTrabs { get; set; }
}

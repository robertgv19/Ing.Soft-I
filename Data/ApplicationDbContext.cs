using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Ing.soft_I.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ing.soft_I.Models.cliente> cliente { get; set; }
        public DbSet<Ing.soft_I.Models.venta> venta { get; set; }
        public DbSet<Ing.soft_I.Models.insumo> insumo { get; set; }
    }
}

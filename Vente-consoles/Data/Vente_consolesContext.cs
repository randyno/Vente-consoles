using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vente_consoles.Models;

namespace Vente_consoles.Data
{
    public class Vente_consolesContext : DbContext
    {
        public Vente_consolesContext (DbContextOptions<Vente_consolesContext> options)
            : base(options)
        {
        }

        public DbSet<Vente_consoles.Models.Manufacturer> Manufacturer { get; set; } = default!;
        public DbSet<Vente_consoles.Models.ConsoleModel> Console { get; set; } = default!;
        public DbSet<Vente_consoles.Models.Ventes> Ventes { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vente_consoles.Data;
using System;
using System.Linq;


namespace Vente_consoles.Models;

public static class SeedData
{
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Vente_consolesContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<Vente_consolesContext>>() ))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                // S’il y a déjà des films dans la base
                if (context.Manufacturer.Any())
                {
                    return; // On ne fait rien
                }
                // Sinon on en ajoute un
                context.Manufacturer.AddRange(
                new Manufacturer
                {
                    Name="Sony",
                    Country="Japan"
                }
                );
                context.SaveChanges();
            }
        }

}





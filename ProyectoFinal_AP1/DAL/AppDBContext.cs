using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProyectoFinal_AP1.Models;
using System;
namespace ProyectoFinal_AP1.DAL;

public class AppDBContext : DbContext 
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Suscripcion> Suscripciones { get; set; }
    public DbSet<Entrenador> Entrenadores { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.Suscripcion)
            .WithOne()
            .HasForeignKey<Usuario>(u => u.IdSuscripcion);

        modelBuilder.Entity<Suscripcion>()
            .HasOne(s => s.Entrenador)
            .WithMany()
            .HasForeignKey(s => s.IdEntrenador);
    }
}

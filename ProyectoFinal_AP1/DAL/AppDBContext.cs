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

    public DbSet<Producto> Productos { get; set; }

    public DbSet<Equipos> Equipos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.Suscripcion)
            .WithOne()
            .HasForeignKey<Usuario>(u => u.IdSuscripcion);

        modelBuilder.Entity<Usuario>()
       .HasOne(u => u.Entrenador)
       .WithMany()
       .HasForeignKey(u => u.IdEntrenador);

        modelBuilder.Entity<Suscripcion>()
            .HasOne(s => s.Entrenador)
            .WithMany()
            .HasForeignKey(s => s.IdEntrenador);

        modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);
        modelBuilder.Entity<Suscripcion>().HasKey(s => s.IdSuscripcion);
        modelBuilder.Entity<Entrenador>().HasKey(e => e.IdEntrenador);
    }
}

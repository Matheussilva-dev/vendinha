using Microsoft.EntityFrameworkCore;
using Vendinha.Models;

namespace Vendinha.Contexts
{
    public class VendinhaDbContext : DbContext
    {
        private string? connectionString;

        public VendinhaDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public VendinhaDbContext(DbContextOptions opt) : base(opt)
        {
        }

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Divida> Dividas => Set<Divida>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityCliente = modelBuilder.Entity<Cliente>();
            entityCliente.ToTable("clientes");
            entityCliente.HasKey(c => c.Id);
            entityCliente.Property(c => c.Id).HasColumnName("id");
            entityCliente.Property(c => c.Nome).HasColumnName("nome");
            entityCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entityCliente.Property(c => c.DataNascimento).HasColumnName("data_nascimento").HasColumnType("date");
            entityCliente.Property(c => c.Email).HasColumnName("email");
            entityCliente.HasIndex(c => c.Cpf).IsUnique();
            entityCliente.HasMany(c => c.Dividas).WithOne().HasForeignKey(d => d.ClienteId);

            var entityDivida = modelBuilder.Entity<Divida>();
            entityDivida.ToTable("dividas");
            entityDivida.HasKey(d => d.Id);
            entityDivida.Property(d => d.Id).HasColumnName("id");
            entityDivida.Property(d => d.ClienteId).HasColumnName("cliente_id");
            entityDivida.Property(d => d.Valor).HasColumnName("valor").HasPrecision(10, 2);
            entityDivida.Property(d => d.Paga).HasColumnName("paga");
            entityDivida.Property(d => d.DataCriacao).HasColumnName("data_criacao").HasColumnType("timestamp");
            entityDivida.Property(d => d.DataPagamento).HasColumnName("data_pagamento").HasColumnType("timestamp");

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                optionsBuilder.UseNpgsql(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SignalR_Menu.Models
{
    public partial class PizzaMenuContext : DbContext
    {
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<PizzaIngredients> PizzaIngredients { get; set; }

        //Måske rettes
        public PizzaMenuContext(DbContextOptions<PizzaMenuContext> options) : base(options)
        {

        }

        public PizzaMenuContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PizzaMenu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredients>(entity =>
            {
                entity.HasKey(e => e.Iid)
                    .HasName("PK__Ingredie__C4972BAC8CF9629B");

                entity.Property(e => e.Iid).HasColumnName("IId");

                entity.Property(e => e.Topping).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__tmp_ms_x__C5775540A7194CD7");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.Title).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PizzaIngredients>(entity =>
            {
                entity.HasKey(e => new { e.Pid, e.Iid })
                    .HasName("PK__PizzaIng__193E27FA1A30E380");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.Iid).HasColumnName("IId");

                entity.HasOne(d => d.I)
                    .WithMany(p => p.PizzaIngredients)
                    .HasForeignKey(d => d.Iid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("IID");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.PizzaIngredients)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PID");
            });
        }
    }
}
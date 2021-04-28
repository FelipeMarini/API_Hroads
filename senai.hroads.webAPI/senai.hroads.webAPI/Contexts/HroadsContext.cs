using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.hroads.webAPI.Domains;

#nullable disable

namespace senai.hroads.webAPI.Contexts
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Personagem> Personagens { get; set; }
        public virtual DbSet<TiposHabilidade> TiposHabilidades { get; set; }
        public object TiposUsuarios { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-7SJR3UU\\SQLEXPRESS; Initial Catalog = Hroads; User Id = sa; Pwd = senai@132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classes__60FFF8012F95663A");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.NomeClasse)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeClasse");
            });

            

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__Habilida__655F752874829E22");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.Property(e => e.IdTiposHabilidade).HasColumnName("idTiposHabilidade");

                entity.Property(e => e.NomeHabilidade)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeHabilidade");

                entity.HasOne(d => d.TiposHabilidades)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTiposHabilidade)
                    .HasConstraintName("FK__Habilidad__idTip__2B3F6F97");
            });

            
            modelBuilder.Entity<Personagem>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__Personag__E175C72E88ADBF35");

                entity.Property(e => e.IdPersonagem).HasColumnName("idPersonagem");

                entity.Property(e => e.CapacidadeMaxMana).HasColumnName("capacidadeMaxMana");

                entity.Property(e => e.CapacidadeMaxVida).HasColumnName("capacidadeMaxVida");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("date")
                    .HasColumnName("dataAtualizacao");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("date")
                    .HasColumnName("dataCriacao");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.NomePersonagem)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomePersonagem");

                entity.HasOne(d => d.Classes)
                    .WithMany(p => p.Personagens)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Personage__idCla__267ABA7A");
            });

            
            modelBuilder.Entity<TiposHabilidade>(entity =>
            {
                entity.HasKey(e => e.IdTiposHabilidade)
                    .HasName("PK__TiposHab__0FF793DB4D78A579");

                entity.ToTable("TiposHabilidade");

                entity.Property(e => e.IdTiposHabilidade).HasColumnName("idTiposHabilidade");

                entity.Property(e => e.NomeTiposHabilidade)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeTiposHabilidade");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
    }
}

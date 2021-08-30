using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace backend.Models
{
    public partial class TccContext : DbContext
    {
        public TccContext()
        {
        }

        public TccContext(DbContextOptions<TccContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbCompra> TbCompra { get; set; }
        public virtual DbSet<TbCompraLivro> TbCompraLivro { get; set; }
        public virtual DbSet<TbEmpregado> TbEmpregado { get; set; }
        public virtual DbSet<TbLivro> TbLivro { get; set; }
        public virtual DbSet<TbLogin> TbLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("host=localhost;user=bookman;password=Space_2020;database=Tcc", x => x.ServerVersion("8.0.22-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("tb_cliente");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("id_login");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.DsCartaoCredito)
                    .HasColumnName("ds_cartao_credito")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCpf)
                    .HasColumnName("ds_cpf")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsRg)
                    .HasColumnName("ds_rg")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsTelefone)
                    .HasColumnName("ds_telefone")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.IdLogin).HasColumnName("id_login");

                entity.Property(e => e.NmCliente)
                    .HasColumnName("nm_cliente")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbCliente)
                    .HasForeignKey(d => d.IdLogin)
                    .HasConstraintName("tb_cliente_ibfk_1");
            });

            modelBuilder.Entity<TbCompra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PRIMARY");

                entity.ToTable("tb_compra");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.Property(e => e.IdCompra).HasColumnName("id_compra");

                entity.Property(e => e.DtCompra)
                    .HasColumnName("dt_compra")
                    .HasColumnType("date");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("decimal(15,2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompra)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_compra_ibfk_1");
            });

            modelBuilder.Entity<TbCompraLivro>(entity =>
            {
                entity.HasKey(e => e.IdCompraLivro)
                    .HasName("PRIMARY");

                entity.ToTable("tb_compra_livro");

                entity.HasIndex(e => e.IdCompra)
                    .HasName("id_compra");

                entity.HasIndex(e => e.IdLivro)
                    .HasName("id_livro");

                entity.Property(e => e.IdCompraLivro).HasColumnName("id_compra_livro");

                entity.Property(e => e.IdCompra).HasColumnName("id_compra");

                entity.Property(e => e.IdLivro).HasColumnName("id_livro");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.TbCompraLivro)
                    .HasForeignKey(d => d.IdCompra)
                    .HasConstraintName("tb_compra_livro_ibfk_2");

                entity.HasOne(d => d.IdLivroNavigation)
                    .WithMany(p => p.TbCompraLivro)
                    .HasForeignKey(d => d.IdLivro)
                    .HasConstraintName("tb_compra_livro_ibfk_1");
            });

            modelBuilder.Entity<TbEmpregado>(entity =>
            {
                entity.HasKey(e => e.IdEmpregado)
                    .HasName("PRIMARY");

                entity.ToTable("tb_empregado");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("id_login");

                entity.Property(e => e.IdEmpregado).HasColumnName("id_empregado");

                entity.Property(e => e.DsCargaHorariaSemanal)
                    .HasColumnName("ds_carga_horaria_semanal")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCargo)
                    .HasColumnName("ds_cargo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCarteiraTrabalho)
                    .HasColumnName("ds_carteira_trabalho")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCep)
                    .HasColumnName("ds_cep")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCpf)
                    .HasColumnName("ds_cpf")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsRg)
                    .HasColumnName("ds_rg")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.IdLogin).HasColumnName("id_login");

                entity.Property(e => e.NmEmpregado)
                    .HasColumnName("nm_empregado")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VlSalario)
                    .HasColumnName("vl_salario")
                    .HasColumnType("decimal(15,2)");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbEmpregado)
                    .HasForeignKey(d => d.IdLogin)
                    .HasConstraintName("tb_empregado_ibfk_1");
            });

            modelBuilder.Entity<TbLivro>(entity =>
            {
                entity.HasKey(e => e.IdLivro)
                    .HasName("PRIMARY");

                entity.ToTable("tb_livro");

                entity.Property(e => e.IdLivro).HasColumnName("id_livro");

                entity.Property(e => e.DsEdicaoLivro)
                    .HasColumnName("ds_edicao_livro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsGenero)
                    .HasColumnName("ds_genero")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSinopse)
                    .HasColumnName("ds_sinopse")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DtPublicacao)
                    .HasColumnName("dt_publicacao")
                    .HasColumnType("date");

                entity.Property(e => e.ImgImagem)
                    .HasColumnName("img_imagem")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'sem-imagem.jpg'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmAutor)
                    .HasColumnName("nm_autor")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmEditora)
                    .HasColumnName("nm_editora")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmLivro)
                    .HasColumnName("nm_livro")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NrPaginas).HasColumnName("nr_paginas");

                entity.Property(e => e.NrSerie)
                    .HasColumnName("nr_serie")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PdfLivro)
                    .HasColumnName("Pdf_livro")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'NenhumArquivoEncontrado.pdf'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TpIdiomaOriginal)
                    .HasColumnName("tp_idioma_original")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VlPreco)
                    .HasColumnName("vl_preco")
                    .HasColumnType("decimal(15,2)");
            });

            modelBuilder.Entity<TbLogin>(entity =>
            {
                entity.HasKey(e => e.IdLogin)
                    .HasName("PRIMARY");

                entity.ToTable("tb_login");

                entity.Property(e => e.IdLogin).HasColumnName("id_login");

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_email")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsPerfil)
                    .HasColumnName("ds_perfil")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasColumnName("ds_senha")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VesteMeAPI.Data;

namespace VesteMeAPI.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    partial class AplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("PedidoProduto", b =>
                {
                    b.Property<int>("PedidosID")
                        .HasColumnType("int");

                    b.Property<int>("ProdutosID")
                        .HasColumnType("int");

                    b.HasKey("PedidosID", "ProdutosID");

                    b.HasIndex("ProdutosID");

                    b.ToTable("PedidoProduto");
                });

            modelBuilder.Entity("ProdutoTamanho", b =>
                {
                    b.Property<int>("ProdutosID")
                        .HasColumnType("int");

                    b.Property<int>("TamanhosID")
                        .HasColumnType("int");

                    b.HasKey("ProdutosID", "TamanhosID");

                    b.HasIndex("TamanhosID");

                    b.ToTable("ProdutoTamanho");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Endereco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Pagamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FormaPagamento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Pedido", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PagamentoID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ID");

                    b.HasIndex("PagamentoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(20000)
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int");

                    b.Property<int>("TamanhoID")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Tamanho", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Tamanhos");
                });

            modelBuilder.Entity("VesteMeAPI.Models.TipoUsuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("ID");

                    b.ToTable("TipoUsuarios");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Celular")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("TipoUsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EnderecoID");

                    b.HasIndex("TipoUsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PedidoProduto", b =>
                {
                    b.HasOne("VesteMeAPI.Models.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VesteMeAPI.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProdutoTamanho", b =>
                {
                    b.HasOne("VesteMeAPI.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VesteMeAPI.Models.Tamanho", null)
                        .WithMany()
                        .HasForeignKey("TamanhosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VesteMeAPI.Models.Pedido", b =>
                {
                    b.HasOne("VesteMeAPI.Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VesteMeAPI.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pagamento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Produto", b =>
                {
                    b.HasOne("VesteMeAPI.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("VesteMeAPI.Models.Usuario", b =>
                {
                    b.HasOne("VesteMeAPI.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VesteMeAPI.Models.TipoUsuario", "TipoUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoUsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("VesteMeAPI.Models.TipoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}

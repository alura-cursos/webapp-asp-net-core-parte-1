using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CasaDoCodigo;

namespace CasaDoCodigo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20170405193509_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CasaDoCodigo.Models.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("PrecoUnitario");

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.ItemPedido", b =>
                {
                    b.HasOne("CasaDoCodigo.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });
        }
    }
}

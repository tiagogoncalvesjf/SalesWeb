﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMVC.Data;

namespace SalesWebMVC.Migrations
{
    [DbContext(typeof(SalesWebMvcContext))]
    [Migration("20210505185417_AtualizacaoCliente")]
    partial class AtualizacaoCliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMVC.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataInsercao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<DateTime>("DataUltimaAlteracao");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.Property<string>("Observacao");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SalesWebMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClienteId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalesWebMVC.Models.Department", b =>
                {
                    b.HasOne("SalesWebMVC.Models.Cliente")
                        .WithMany("List")
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}

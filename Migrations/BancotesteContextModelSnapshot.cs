﻿// <auto-generated />
using System;
using MVC_test.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_test.Migrations
{
    [DbContext(typeof(BancotesteContext))]
    partial class BancotesteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MVC_test.Models.Armazem", b =>
                {
                    b.Property<DateTime>("Data");

                    b.HasKey("Data");

                    b.ToTable("Armazems");
                });

            modelBuilder.Entity("MVC_test.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ArmazemData");

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("ArmazemData");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MVC_test.Models.Produtos", b =>
                {
                    b.HasOne("MVC_test.Models.Armazem")
                        .WithMany("Lista")
                        .HasForeignKey("ArmazemData");
                });
#pragma warning restore 612, 618
        }
    }
}
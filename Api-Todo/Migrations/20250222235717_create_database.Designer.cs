﻿// <auto-generated />
using System;
using Api_Todo.Models.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Todo.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20250222235717_create_database")]
    partial class create_database
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api_Todo.Models.DB.Todo", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}

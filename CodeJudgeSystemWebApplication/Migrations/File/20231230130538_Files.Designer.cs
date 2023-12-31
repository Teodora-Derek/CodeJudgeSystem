﻿// <auto-generated />
using System;
using CodeJudgeSystemWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeJudgeSystemWebApplication.Migrations.File
{
    [DbContext(typeof(FileContext))]
    [Migration("20231230130538_Files")]
    partial class Files
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeJudgeSystemWebApplication.Models.FileModel", b =>
                {
                    b.Property<int>("FileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FileExtention")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UploadTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("FileID");

                    b.ToTable("Files");
                });
#pragma warning restore 612, 618
        }
    }
}

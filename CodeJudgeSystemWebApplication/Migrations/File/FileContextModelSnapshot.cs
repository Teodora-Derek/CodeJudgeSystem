﻿// <auto-generated />
using System;
using CodeJudgeSystemWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeJudgeSystemWebApplication.Migrations.File
{
    [DbContext(typeof(FileContext))]
    partial class FileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeJudgeSystemWebApplication.Models.AssignmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AssignmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ExpectedInputAndOutputPairs")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TargetGroup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AssignmentModel");
                });

            modelBuilder.Entity("CodeJudgeSystemWebApplication.Models.FileModel", b =>
                {
                    b.Property<int>("FileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<string>("FileExtention")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<DateTime>("UploadTime")
                        .HasColumnType("datetime");

                    b.HasKey("FileID");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("CodeJudgeSystemWebApplication.Models.FileModel", b =>
                {
                    b.HasOne("CodeJudgeSystemWebApplication.Models.AssignmentModel", "Assignment")
                        .WithMany("Files")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("CodeJudgeSystemWebApplication.Models.AssignmentModel", b =>
                {
                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}

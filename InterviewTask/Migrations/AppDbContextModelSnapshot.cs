﻿// <auto-generated />
using System;
using InterviewTask.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterviewTask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InterviewTask.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1349),
                            Name = "Developers"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1385),
                            Name = "HR Manager"
                        });
                });

            modelBuilder.Entity("InterviewTask.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1309),
                            CreateDate = new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1318),
                            DepartmentId = 1,
                            Name = "Khalid",
                            Surname = "Rajabov"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1339),
                            CreateDate = new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1339),
                            DepartmentId = 1,
                            Name = "Felix",
                            Surname = "Paw"
                        });
                });

            modelBuilder.Entity("InterviewTask.Models.Employee", b =>
                {
                    b.HasOne("InterviewTask.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("InterviewTask.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YourDay.DAL;

#nullable disable

namespace YourDay.DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240323235210_MergePasswordOnHashAndSalt")]
    partial class MergePasswordOnHashAndSalt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SpecializationDtoUserDto", b =>
                {
                    b.Property<int>("SpecializationsId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersId")
                        .HasColumnType("int");

                    b.HasKey("SpecializationsId", "WorkersId");

                    b.HasIndex("WorkersId");

                    b.ToTable("SpecializationDtoUserDto");
                });

            modelBuilder.Entity("TaskDtoUserDto", b =>
                {
                    b.Property<int>("WorkerTasksId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersId")
                        .HasColumnType("int");

                    b.HasKey("WorkerTasksId", "WorkersId");

                    b.HasIndex("WorkersId");

                    b.ToTable("TaskDtoUserDto");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.HistoryDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("DateTime");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.OrderDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("CountPeople")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("DateTime");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("OrderName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Еvaluation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.SpecializationDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.TaskDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("SpecializationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("DateTime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.UserDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Hash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.UserProfilesPictureDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("UserProfilesPictures");
                });

            modelBuilder.Entity("SpecializationDtoUserDto", b =>
                {
                    b.HasOne("YourDay.DAL.Dtos.SpecializationDto", null)
                        .WithMany()
                        .HasForeignKey("SpecializationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YourDay.DAL.Dtos.UserDto", null)
                        .WithMany()
                        .HasForeignKey("WorkersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskDtoUserDto", b =>
                {
                    b.HasOne("YourDay.DAL.Dtos.TaskDto", null)
                        .WithMany()
                        .HasForeignKey("WorkerTasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YourDay.DAL.Dtos.UserDto", null)
                        .WithMany()
                        .HasForeignKey("WorkersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.HistoryDto", b =>
                {
                    b.HasOne("YourDay.DAL.Dtos.OrderDto", "Order")
                        .WithMany("Histories")
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.OrderDto", b =>
                {
                    b.HasOne("YourDay.DAL.Dtos.UserDto", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("YourDay.DAL.Dtos.UserDto", "Manager")
                        .WithMany("Orders")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Client");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.TaskDto", b =>
                {
                    b.HasOne("YourDay.DAL.Dtos.OrderDto", "Order")
                        .WithMany("Tasks")
                        .HasForeignKey("OrderId");

                    b.HasOne("YourDay.DAL.Dtos.SpecializationDto", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId");

                    b.Navigation("Order");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.UserProfilesPictureDto", b =>
                {
                    b.HasOne("YourDay.DAL.Dtos.UserDto", "User")
                        .WithOne("Picture")
                        .HasForeignKey("YourDay.DAL.Dtos.UserProfilesPictureDto", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.OrderDto", b =>
                {
                    b.Navigation("Histories");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("YourDay.DAL.Dtos.UserDto", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Picture")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

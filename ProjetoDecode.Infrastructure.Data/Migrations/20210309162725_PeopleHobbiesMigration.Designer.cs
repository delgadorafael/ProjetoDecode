﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoDecode.Infrastructure.Data.Context;

namespace ProjetoDecode.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DecodeContext))]
    [Migration("20210309162725_PeopleHobbiesMigration")]
    partial class PeopleHobbiesMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.PeopleHobbies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HobbiesId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HobbiesId");

                    b.HasIndex("PersonId");

                    b.ToTable("PeopleHobbies");
                });

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfessionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.PeopleHobbies", b =>
                {
                    b.HasOne("ProjetoDecode.Domain.Entities.Hobby", "Hobbies")
                        .WithMany("PeopleHobbies")
                        .HasForeignKey("HobbiesId");

                    b.HasOne("ProjetoDecode.Domain.Entities.Person", "Person")
                        .WithMany("PeopleHobbies")
                        .HasForeignKey("PersonId");

                    b.Navigation("Hobbies");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.Person", b =>
                {
                    b.HasOne("ProjetoDecode.Domain.Entities.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId");

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.Hobby", b =>
                {
                    b.Navigation("PeopleHobbies");
                });

            modelBuilder.Entity("ProjetoDecode.Domain.Entities.Person", b =>
                {
                    b.Navigation("PeopleHobbies");
                });
#pragma warning restore 612, 618
        }
    }
}

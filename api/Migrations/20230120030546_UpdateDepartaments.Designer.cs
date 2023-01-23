﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230120030546_UpdateDepartaments")]
    partial class UpdateDepartaments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartamentId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("PhonePrefix")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<float>("Population")
                        .HasColumnType("real");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<float>("Surface")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("api.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AircraftPrefix")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("Currency")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("CurrencyCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ISOCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("InternetDomain")
                        .HasColumnType("text");

                    b.Property<string[]>("Languages")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("PhonePrefix")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<float>("Population")
                        .HasColumnType("real");

                    b.Property<string>("RadioPrefix")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("StateCapital")
                        .HasColumnType("text");

                    b.Property<float>("Surface")
                        .HasColumnType("real");

                    b.Property<string>("TimeZone")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.ToTable("Country", (string)null);
                });

            modelBuilder.Entity("api.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityCapitalId")
                        .HasColumnType("integer");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string[]>("Municipalities")
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("PhonePrefix")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<float?>("Population")
                        .HasColumnType("real");

                    b.Property<float>("Surface")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CityCapitalId");

                    b.HasIndex("CountryId");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("api.Models.President", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateOnly>("EndPeriodDate")
                        .HasColumnType("date");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("PoliticalParty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("StartPeriodDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("President", (string)null);
                });

            modelBuilder.Entity("api.Models.TouristAttraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string[]>("Images")
                        .HasColumnType("text[]");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("TouristAttraction", (string)null);
                });

            modelBuilder.Entity("api.Models.City", b =>
                {
                    b.HasOne("api.Models.Department", "Departament")
                        .WithMany("Cities")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departament");
                });

            modelBuilder.Entity("api.Models.Department", b =>
                {
                    b.HasOne("api.Models.City", "CityCapital")
                        .WithMany()
                        .HasForeignKey("CityCapitalId");

                    b.HasOne("api.Models.Country", "Country")
                        .WithMany("Departments")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CityCapital");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("api.Models.President", b =>
                {
                    b.HasOne("api.Models.City", "City")
                        .WithMany("Presidents")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Country", null)
                        .WithMany("Presidents")
                        .HasForeignKey("CountryId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("api.Models.TouristAttraction", b =>
                {
                    b.HasOne("api.Models.City", "City")
                        .WithMany("TouristAttractions")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("api.Models.City", b =>
                {
                    b.Navigation("Presidents");

                    b.Navigation("TouristAttractions");
                });

            modelBuilder.Entity("api.Models.Country", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Presidents");
                });

            modelBuilder.Entity("api.Models.Department", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}

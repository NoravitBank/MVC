﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220615061326_PositionEmployeeRelation")]
    partial class PositionEmployeeRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication1.Models.POSITION", b =>
                {
                    b.Property<int>("POSITION_CODE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("POSITION_CODE")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("POSITION_CODE"), 1L, 1);

                    b.Property<string>("POSITION_NAME_ENG")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("POSITION_NAME_ENG")
                        .HasColumnOrder(3);

                    b.Property<string>("POSITION_NAME_THA")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("POSITION_NAME_THA")
                        .HasColumnOrder(2);

                    b.HasKey("POSITION_CODE");

                    b.ToTable("POSITION");
                });
#pragma warning restore 612, 618
        }
    }
}

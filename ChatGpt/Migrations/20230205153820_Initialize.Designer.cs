﻿// <auto-generated />
using System;
using ChatGpt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatGpt.Migrations
{
    [DbContext(typeof(MessagingContext))]
    [Migration("20230205153820_Initialize")]
    partial class Initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("ChatGpt.Data.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}

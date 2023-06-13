﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.Shop.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int?>("ProductDetailsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 712.021981759007m,
                            ReleaseDate = new DateTime(2022, 10, 26, 0, 19, 53, 578, DateTimeKind.Local).AddTicks(5525),
                            Title = "Gorgeous Wooden Chair"
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "7",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 839.010165513032m,
                            ReleaseDate = new DateTime(2023, 5, 7, 20, 58, 27, 214, DateTimeKind.Local).AddTicks(7360),
                            Title = "Handcrafted Steel Shoes"
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "1",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 198.083692779804m,
                            ReleaseDate = new DateTime(2022, 8, 26, 15, 52, 10, 487, DateTimeKind.Local).AddTicks(9352),
                            Title = "Handmade Granite Table"
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "1",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 160.643399712929m,
                            ReleaseDate = new DateTime(2023, 3, 28, 4, 5, 40, 847, DateTimeKind.Local).AddTicks(724),
                            Title = "Handmade Wooden Table"
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "0",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 359.887736376788m,
                            ReleaseDate = new DateTime(2022, 9, 28, 5, 23, 52, 576, DateTimeKind.Local).AddTicks(6911),
                            Title = "Intelligent Steel Salad"
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "8",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 181.360829243139m,
                            ReleaseDate = new DateTime(2023, 4, 11, 17, 11, 25, 686, DateTimeKind.Local).AddTicks(4187),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 7,
                            Barcode = "1",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 938.297015022625m,
                            ReleaseDate = new DateTime(2022, 11, 10, 16, 23, 38, 96, DateTimeKind.Local).AddTicks(4226),
                            Title = "Unbranded Steel Car"
                        },
                        new
                        {
                            Id = 8,
                            Barcode = "3",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 223.882037785315m,
                            ReleaseDate = new DateTime(2023, 2, 3, 7, 38, 5, 784, DateTimeKind.Local).AddTicks(6440),
                            Title = "Tasty Plastic Cheese"
                        },
                        new
                        {
                            Id = 9,
                            Barcode = "0",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 249.172251003875m,
                            ReleaseDate = new DateTime(2022, 7, 25, 23, 37, 21, 241, DateTimeKind.Local).AddTicks(3900),
                            Title = "Handcrafted Fresh Sausages"
                        },
                        new
                        {
                            Id = 10,
                            Barcode = "1",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 905.322284099796m,
                            ReleaseDate = new DateTime(2023, 5, 17, 15, 19, 30, 702, DateTimeKind.Local).AddTicks(6549),
                            Title = "Fantastic Frozen Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 842.480734222792m,
                            ReleaseDate = new DateTime(2023, 3, 16, 8, 33, 34, 844, DateTimeKind.Local).AddTicks(3703),
                            Title = "Generic Steel Ball"
                        },
                        new
                        {
                            Id = 12,
                            Barcode = "1",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 928.928430071533m,
                            ReleaseDate = new DateTime(2023, 3, 24, 13, 5, 31, 618, DateTimeKind.Local).AddTicks(2426),
                            Title = "Ergonomic Rubber Car"
                        },
                        new
                        {
                            Id = 13,
                            Barcode = "6",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 706.948686653259m,
                            ReleaseDate = new DateTime(2023, 2, 21, 18, 19, 0, 537, DateTimeKind.Local).AddTicks(8398),
                            Title = "Generic Steel Pizza"
                        },
                        new
                        {
                            Id = 14,
                            Barcode = "3",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 306.262494314584m,
                            ReleaseDate = new DateTime(2022, 8, 18, 7, 31, 39, 25, DateTimeKind.Local).AddTicks(4700),
                            Title = "Small Metal Sausages"
                        },
                        new
                        {
                            Id = 15,
                            Barcode = "2",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 378.222576259273m,
                            ReleaseDate = new DateTime(2023, 3, 9, 0, 37, 32, 55, DateTimeKind.Local).AddTicks(1839),
                            Title = "Fantastic Soft Pants"
                        },
                        new
                        {
                            Id = 16,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 461.718092748764m,
                            ReleaseDate = new DateTime(2022, 6, 26, 16, 32, 20, 522, DateTimeKind.Local).AddTicks(683),
                            Title = "Gorgeous Frozen Towels"
                        },
                        new
                        {
                            Id = 17,
                            Barcode = "7",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 126.128098112125m,
                            ReleaseDate = new DateTime(2023, 2, 3, 6, 53, 52, 100, DateTimeKind.Local).AddTicks(160),
                            Title = "Tasty Steel Cheese"
                        },
                        new
                        {
                            Id = 18,
                            Barcode = "8",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 530.970371435383m,
                            ReleaseDate = new DateTime(2023, 1, 31, 8, 36, 33, 459, DateTimeKind.Local).AddTicks(3242),
                            Title = "Gorgeous Granite Cheese"
                        },
                        new
                        {
                            Id = 19,
                            Barcode = "9",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 913.003066283186m,
                            ReleaseDate = new DateTime(2022, 6, 26, 19, 54, 33, 38, DateTimeKind.Local).AddTicks(6582),
                            Title = "Sleek Rubber Chicken"
                        },
                        new
                        {
                            Id = 20,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 940.814879371698m,
                            ReleaseDate = new DateTime(2022, 11, 17, 21, 25, 17, 520, DateTimeKind.Local).AddTicks(9817),
                            Title = "Intelligent Wooden Salad"
                        },
                        new
                        {
                            Id = 21,
                            Barcode = "4",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 479.41424090062m,
                            ReleaseDate = new DateTime(2023, 1, 26, 8, 48, 11, 709, DateTimeKind.Local).AddTicks(2186),
                            Title = "Handcrafted Wooden Sausages"
                        },
                        new
                        {
                            Id = 22,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 320.499838554068m,
                            ReleaseDate = new DateTime(2022, 9, 8, 4, 15, 33, 978, DateTimeKind.Local).AddTicks(9896),
                            Title = "Sleek Granite Car"
                        },
                        new
                        {
                            Id = 23,
                            Barcode = "6",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 478.915239043029m,
                            ReleaseDate = new DateTime(2023, 1, 7, 22, 5, 41, 297, DateTimeKind.Local).AddTicks(3451),
                            Title = "Small Wooden Car"
                        },
                        new
                        {
                            Id = 24,
                            Barcode = "2",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 910.785444308438m,
                            ReleaseDate = new DateTime(2023, 2, 8, 14, 42, 0, 526, DateTimeKind.Local).AddTicks(6634),
                            Title = "Sleek Steel Shirt"
                        },
                        new
                        {
                            Id = 25,
                            Barcode = "3",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 802.238750720974m,
                            ReleaseDate = new DateTime(2023, 2, 24, 16, 10, 52, 90, DateTimeKind.Local).AddTicks(3076),
                            Title = "Incredible Frozen Mouse"
                        },
                        new
                        {
                            Id = 26,
                            Barcode = "7",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 150.818741621831m,
                            ReleaseDate = new DateTime(2022, 12, 20, 9, 47, 12, 213, DateTimeKind.Local).AddTicks(8334),
                            Title = "Incredible Wooden Chair"
                        },
                        new
                        {
                            Id = 27,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 721.773541800572m,
                            ReleaseDate = new DateTime(2022, 9, 10, 21, 50, 48, 209, DateTimeKind.Local).AddTicks(9897),
                            Title = "Gorgeous Plastic Chips"
                        },
                        new
                        {
                            Id = 28,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 688.245783060904m,
                            ReleaseDate = new DateTime(2022, 12, 4, 0, 16, 43, 321, DateTimeKind.Local).AddTicks(5110),
                            Title = "Incredible Fresh Bacon"
                        },
                        new
                        {
                            Id = 29,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 553.558320945389m,
                            ReleaseDate = new DateTime(2023, 2, 26, 10, 47, 37, 314, DateTimeKind.Local).AddTicks(6406),
                            Title = "Incredible Soft Computer"
                        },
                        new
                        {
                            Id = 30,
                            Barcode = "4",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 663.536718269594m,
                            ReleaseDate = new DateTime(2022, 6, 23, 11, 43, 0, 530, DateTimeKind.Local).AddTicks(8185),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 31,
                            Barcode = "2",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 922.479030014704m,
                            ReleaseDate = new DateTime(2023, 5, 19, 10, 8, 49, 727, DateTimeKind.Local).AddTicks(6357),
                            Title = "Handcrafted Concrete Tuna"
                        },
                        new
                        {
                            Id = 32,
                            Barcode = "3",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 255.49067058018m,
                            ReleaseDate = new DateTime(2023, 2, 27, 5, 56, 15, 666, DateTimeKind.Local).AddTicks(6783),
                            Title = "Gorgeous Wooden Fish"
                        },
                        new
                        {
                            Id = 33,
                            Barcode = "7",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 955.272407213818m,
                            ReleaseDate = new DateTime(2022, 12, 5, 6, 25, 16, 917, DateTimeKind.Local).AddTicks(2659),
                            Title = "Handcrafted Frozen Keyboard"
                        },
                        new
                        {
                            Id = 34,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 151.982358236323m,
                            ReleaseDate = new DateTime(2022, 7, 3, 23, 41, 4, 756, DateTimeKind.Local).AddTicks(247),
                            Title = "Intelligent Plastic Chair"
                        },
                        new
                        {
                            Id = 35,
                            Barcode = "9",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 434.299358334532m,
                            ReleaseDate = new DateTime(2022, 7, 22, 4, 33, 22, 750, DateTimeKind.Local).AddTicks(9917),
                            Title = "Unbranded Wooden Pizza"
                        },
                        new
                        {
                            Id = 36,
                            Barcode = "4",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 57.7988712865854m,
                            ReleaseDate = new DateTime(2022, 8, 10, 23, 7, 20, 284, DateTimeKind.Local).AddTicks(1706),
                            Title = "Gorgeous Rubber Bacon"
                        },
                        new
                        {
                            Id = 37,
                            Barcode = "7",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 883.980300599234m,
                            ReleaseDate = new DateTime(2022, 11, 6, 14, 40, 33, 679, DateTimeKind.Local).AddTicks(9880),
                            Title = "Handcrafted Rubber Shirt"
                        },
                        new
                        {
                            Id = 38,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 822.452619476455m,
                            ReleaseDate = new DateTime(2022, 8, 18, 12, 42, 13, 999, DateTimeKind.Local).AddTicks(1250),
                            Title = "Rustic Granite Shoes"
                        },
                        new
                        {
                            Id = 39,
                            Barcode = "7",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 22.2432652671092m,
                            ReleaseDate = new DateTime(2022, 11, 12, 20, 20, 28, 558, DateTimeKind.Local).AddTicks(6393),
                            Title = "Sleek Granite Chair"
                        },
                        new
                        {
                            Id = 40,
                            Barcode = "2",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 158.364214679396m,
                            ReleaseDate = new DateTime(2023, 1, 30, 17, 6, 45, 182, DateTimeKind.Local).AddTicks(4155),
                            Title = "Incredible Rubber Soap"
                        },
                        new
                        {
                            Id = 41,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 533.504530191656m,
                            ReleaseDate = new DateTime(2023, 3, 15, 0, 12, 7, 330, DateTimeKind.Local).AddTicks(6197),
                            Title = "Awesome Soft Fish"
                        },
                        new
                        {
                            Id = 42,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 265.709933652407m,
                            ReleaseDate = new DateTime(2023, 3, 6, 11, 23, 6, 760, DateTimeKind.Local).AddTicks(1501),
                            Title = "Intelligent Cotton Tuna"
                        },
                        new
                        {
                            Id = 43,
                            Barcode = "2",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 294.402654204239m,
                            ReleaseDate = new DateTime(2022, 8, 29, 3, 9, 20, 316, DateTimeKind.Local).AddTicks(472),
                            Title = "Refined Soft Bike"
                        },
                        new
                        {
                            Id = 44,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 741.648888164036m,
                            ReleaseDate = new DateTime(2022, 9, 2, 0, 49, 45, 474, DateTimeKind.Local).AddTicks(8118),
                            Title = "Handmade Cotton Bacon"
                        },
                        new
                        {
                            Id = 45,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 825.239833488706m,
                            ReleaseDate = new DateTime(2022, 8, 10, 20, 56, 8, 544, DateTimeKind.Local).AddTicks(9633),
                            Title = "Small Soft Tuna"
                        },
                        new
                        {
                            Id = 46,
                            Barcode = "1",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 305.894089151124m,
                            ReleaseDate = new DateTime(2022, 12, 14, 1, 38, 20, 104, DateTimeKind.Local).AddTicks(3137),
                            Title = "Practical Frozen Computer"
                        },
                        new
                        {
                            Id = 47,
                            Barcode = "4",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 778.911179241683m,
                            ReleaseDate = new DateTime(2022, 8, 18, 20, 37, 54, 406, DateTimeKind.Local).AddTicks(6272),
                            Title = "Rustic Wooden Mouse"
                        },
                        new
                        {
                            Id = 48,
                            Barcode = "2",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 318.709401070936m,
                            ReleaseDate = new DateTime(2022, 9, 30, 17, 30, 11, 832, DateTimeKind.Local).AddTicks(5904),
                            Title = "Handcrafted Metal Mouse"
                        },
                        new
                        {
                            Id = 49,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 463.195345650052m,
                            ReleaseDate = new DateTime(2022, 11, 13, 22, 12, 15, 434, DateTimeKind.Local).AddTicks(5106),
                            Title = "Handcrafted Rubber Salad"
                        },
                        new
                        {
                            Id = 50,
                            Barcode = "6",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 717.609017980569m,
                            ReleaseDate = new DateTime(2023, 4, 2, 11, 21, 14, 614, DateTimeKind.Local).AddTicks(3793),
                            Title = "Incredible Plastic Shoes"
                        });
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductDetails", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Manufactuer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductSuppliers", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "SupplierId");

                    b.HasIndex("SupplierId");

                    b.ToTable("ProductSuppliers");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContantEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.HasOne("P06Shop.Shared.Shop.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductDetails", b =>
                {
                    b.HasOne("P06Shop.Shared.Shop.Product", "Product")
                        .WithOne("ProductDetails")
                        .HasForeignKey("P06Shop.Shared.Shop.ProductDetails", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductSuppliers", b =>
                {
                    b.HasOne("P06Shop.Shared.Shop.Product", "Product")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P06Shop.Shared.Shop.Supplier", "Supplier")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.Navigation("ProductDetails");

                    b.Navigation("ProductSuppliers");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Supplier", b =>
                {
                    b.Navigation("ProductSuppliers");
                });
#pragma warning restore 612, 618
        }
    }
}

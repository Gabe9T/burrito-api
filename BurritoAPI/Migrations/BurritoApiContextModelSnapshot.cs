﻿// <auto-generated />
using BurritoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurritoAPI.Migrations
{
    [DbContext(typeof(BurritoApiContext))]
    partial class BurritoApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BurritoApi.Models.Burrito", b =>
                {
                    b.Property<int>("BurritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Protein")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.Property<string>("Review")
                        .HasColumnType("longtext");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BurritoId");

                    b.ToTable("Burritos");

                    b.HasData(
                        new
                        {
                            BurritoId = 1,
                            Location = "Beto's",
                            Name = "Pastor Burrito",
                            Price = 11.00m,
                            Protein = "Pork",
                            Rating = 8.8000000000000007,
                            Review = "Very juicy pork, choice of black or pinto beans with rice, cheese, sour cream, onions, and cilantro. All salsas included are high quality and not watery.",
                            User = "Gabe"
                        },
                        new
                        {
                            BurritoId = 2,
                            Location = "Los Gorditos",
                            Name = "Veggie Soy Curl Burrito",
                            Price = 12.00m,
                            Protein = "Soy Curls",
                            Rating = 8.1999999999999993,
                            Review = "Best vegetarian option in town. Comes with fajita veggies, beans, rice, sour cream, and cheese. Salsa bar is not to be slept on.",
                            User = "Gabe"
                        },
                        new
                        {
                            BurritoId = 3,
                            Location = "Taqueria Santa Cruz",
                            Name = "Pollo Burrito Supreme",
                            Price = 9.00m,
                            Protein = "Chicken",
                            Rating = 8.5,
                            Review = "review here",
                            User = "Gabe"
                        },
                        new
                        {
                            BurritoId = 4,
                            Location = "Pepinos",
                            Name = "Asada Burrito Supremo",
                            Price = 14.00m,
                            Protein = "Beef",
                            Rating = 8.4000000000000004,
                            Review = "Review Here",
                            User = "Ravin"
                        },
                        new
                        {
                            BurritoId = 5,
                            Location = "Korean Twist",
                            Name = "Beef Bulgogi Burrito",
                            Price = 11.00m,
                            Protein = "Beef",
                            Rating = 8.9000000000000004,
                            Review = "Review Here",
                            User = "Ravin"
                        },
                        new
                        {
                            BurritoId = 6,
                            Location = "Muchas Gracias",
                            Name = "Double Bacon Breakfast Burrito",
                            Price = 8.00m,
                            Protein = "Pork",
                            Rating = 7.7000000000000002,
                            Review = "Review Here",
                            User = "Ravin"
                        },
                        new
                        {
                            BurritoId = 7,
                            Location = "King Burrito",
                            Name = "King Burito add Rice",
                            Price = 6.00m,
                            Protein = "Beef",
                            Rating = 8.1999999999999993,
                            Review = "Review Here",
                            User = "Ravin"
                        },
                        new
                        {
                            BurritoId = 8,
                            Location = "La Bonita",
                            Name = "Carnitas Burrito",
                            Price = 10.75m,
                            Protein = "Beef",
                            Rating = 8.0999999999999996,
                            Review = "Review Here",
                            User = "Noah"
                        },
                        new
                        {
                            BurritoId = 9,
                            Location = "Birria Pepe Chile",
                            Name = "Birria Burrito",
                            Price = 10.00m,
                            Protein = "Beef",
                            Rating = 8.6999999999999993,
                            Review = "Review Here",
                            User = "Noah"
                        },
                        new
                        {
                            BurritoId = 10,
                            Location = "Tito's",
                            Name = "Shrimp Burrito",
                            Price = 11.00m,
                            Protein = "Shrimp",
                            Rating = 8.3000000000000007,
                            Review = "Review Here",
                            User = "Noah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

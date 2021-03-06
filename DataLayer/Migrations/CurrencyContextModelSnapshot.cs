﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using currency_converter.DAL;

namespace DataLayer.Migrations
{
    [DbContext(typeof(CurrencyContext))]
    partial class CurrencyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("currency_converter.Repository.Currency", b =>
                {
                    b.Property<string>("CharCode")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Nominal")
                        .HasColumnName("Nominal")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Value")
                        .HasColumnName("Value")
                        .HasColumnType("REAL");

                    b.HasKey("CharCode");

                    b.ToTable("Currency");

                    b.HasData(
                        new
                        {
                            CharCode = "RUB",
                            LastUpdate = new DateTime(2020, 8, 26, 2, 55, 5, 895, DateTimeKind.Local).AddTicks(6240),
                            Name = "Российский рубль",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "AUD",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Австралийский доллар",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "AZN",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Азербайджанский манат",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "GBP",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Фунт стерлингов Соединенного королевства",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "AMD",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Армянских драмов",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "BYN",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Белорусский рубль",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "BGN",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Болгарский лев",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "BRL",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Бразильский реал",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "HUF",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Венгерских форинтов",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "HKD",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Гонконгских долларов",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "DKK",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Датская крона",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "USD",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Доллар США",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "EUR",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Евро",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "INR",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Индийских рупий",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "KZT",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Казахстанских тенге",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "CAD",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Канадский доллар",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "KGS",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Киргизских сомов",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "CNY",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Китайский юань",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "MDL",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Молдавских леев",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "NOK",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Норвежских крон",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "PLN",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Польский злотый",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "RON",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Румынский лей",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "XDR",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "СДР (специальные права заимствования)",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "SGD",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Сингапурский доллар",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "TJS",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Таджикских сомони",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "TRY",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Турецкая лира",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "TMT",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Новый туркменский манат",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "UZS",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Узбекских сумов",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "UAH",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Украинских гривен",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "CZK",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Чешских крон",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "SEK",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Шведских крон",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "CHF",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Швейцарский франк",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "ZAR",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Южноафриканских рэндов",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "KRW",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Вон Республики Корея",
                            Nominal = 1,
                            Value = 1.0
                        },
                        new
                        {
                            CharCode = "JPY",
                            LastUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Японских иен",
                            Nominal = 1,
                            Value = 1.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

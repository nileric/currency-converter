using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    CharCode = table.Column<string>(nullable: false),
                    Nominal = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CharCode);
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "RUB", new DateTime(2020, 8, 26, 2, 55, 5, 895, DateTimeKind.Local).AddTicks(6240), "Российский рубль", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "NOK", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Норвежских крон", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "PLN", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Польский злотый", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "RON", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Румынский лей", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "XDR", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "СДР (специальные права заимствования)", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "SGD", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Сингапурский доллар", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "TJS", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Таджикских сомони", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "MDL", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Молдавских леев", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "TRY", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Турецкая лира", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "UZS", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Узбекских сумов", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "UAH", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Украинских гривен", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "CZK", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Чешских крон", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "SEK", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Шведских крон", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "CHF", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Швейцарский франк", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "ZAR", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Южноафриканских рэндов", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "TMT", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Новый туркменский манат", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "KRW", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Вон Республики Корея", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "CNY", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Китайский юань", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "CAD", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Канадский доллар", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "AUD", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Австралийский доллар", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "AZN", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Азербайджанский манат", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "GBP", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Фунт стерлингов Соединенного королевства", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "AMD", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Армянских драмов", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "BYN", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Белорусский рубль", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "BGN", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Болгарский лев", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "KGS", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Киргизских сомов", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "BRL", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бразильский реал", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "HKD", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Гонконгских долларов", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "DKK", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Датская крона", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "USD", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доллар США", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "EUR", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Евро", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "INR", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Индийских рупий", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "KZT", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Казахстанских тенге", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "HUF", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Венгерских форинтов", 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CharCode", "LastUpdate", "Name", "Nominal", "Value" },
                values: new object[] { "JPY", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Японских иен", 1, 1.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currency");
        }
    }
}

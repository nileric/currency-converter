using currency_converter.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace currency_converter.DAL
{
    public class CurrencyContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Currencies.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().ToTable("Currency");
            modelBuilder.Entity<Currency>().HasKey(c => c.CharCode);
            modelBuilder.Entity<Currency>().Property(c => c.Name).HasColumnName("Name");
            modelBuilder.Entity<Currency>().Property(c => c.Nominal).HasColumnName("Nominal");
            modelBuilder.Entity<Currency>().Property(c => c.Value).HasColumnName("Value");

            DateTime dummy = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            modelBuilder.Entity<Currency>()
                .HasData(
                    new Currency("RUB", 1, "Российский рубль", 1, DateTime.Now),
                    new Currency("AUD", 1, "Австралийский доллар", 1, dummy),
                    new Currency("AZN", 1, "Азербайджанский манат", 1, dummy),
                    new Currency("GBP", 1, "Фунт стерлингов Соединенного королевства", 1, dummy),
                    new Currency("AMD", 1, "Армянских драмов", 1, dummy),
                    new Currency("BYN", 1, "Белорусский рубль", 1, dummy),
                    new Currency("BGN", 1, "Болгарский лев", 1, dummy),
                    new Currency("BRL", 1, "Бразильский реал", 1, dummy),
                    new Currency("HUF", 1, "Венгерских форинтов", 1, dummy),
                    new Currency("HKD", 1, "Гонконгских долларов", 1, dummy),
                    new Currency("DKK", 1, "Датская крона", 1, dummy),
                    new Currency("USD", 1, "Доллар США", 1, dummy),
                    new Currency("EUR", 1, "Евро", 1, dummy),
                    new Currency("INR", 1, "Индийских рупий", 1, dummy),
                    new Currency("KZT", 1, "Казахстанских тенге", 1, dummy),
                    new Currency("CAD", 1, "Канадский доллар", 1, dummy),
                    new Currency("KGS", 1, "Киргизских сомов", 1, dummy),
                    new Currency("CNY", 1, "Китайский юань", 1, dummy),
                    new Currency("MDL", 1, "Молдавских леев", 1, dummy),
                    new Currency("NOK", 1, "Норвежских крон", 1, dummy),
                    new Currency("PLN", 1, "Польский злотый", 1, dummy),
                    new Currency("RON", 1, "Румынский лей", 1, dummy),
                    new Currency("XDR", 1, "СДР (специальные права заимствования)", 1, dummy),
                    new Currency("SGD", 1, "Сингапурский доллар", 1, dummy),
                    new Currency("TJS", 1, "Таджикских сомони", 1, dummy),
                    new Currency("TRY", 1, "Турецкая лира", 1, dummy),
                    new Currency("TMT", 1, "Новый туркменский манат", 1, dummy),
                    new Currency("UZS", 1, "Узбекских сумов", 1, dummy),
                    new Currency("UAH", 1, "Украинских гривен", 1, dummy),
                    new Currency("CZK", 1, "Чешских крон", 1, dummy),
                    new Currency("SEK", 1, "Шведских крон", 1, dummy),
                    new Currency("CHF", 1, "Швейцарский франк", 1, dummy),
                    new Currency("ZAR", 1, "Южноафриканских рэндов", 1, dummy),
                    new Currency("KRW", 1, "Вон Республики Корея", 1, dummy),
                    new Currency("JPY", 1, "Японских иен", 1, dummy)
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}

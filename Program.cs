using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._03
{
    public class Firma
    {
        public string NazvaFirmi { get; set; }
        public DateTime DataZasnuyvannya { get; set; }
        public string ProfilBiznesu { get; set; }
        public string PIBDirektora { get; set; }
        public int KількістьПрацівників { get; set; }
        public string Adresa { get; set; }

        public Firma(string nazvaFirmi, DateTime dataZasnuyvannya, string profilBiznesu,
                     string pibDirektora, int кількістьПрацівників, string adresa)
        {
            NazvaFirmi = nazvaFirmi;
            DataZasnuyvannya = dataZasnuyvannya;
            ProfilBiznesu = profilBiznesu;
            PIBDirektora = pibDirektora;
            KількістьПрацівників = кількістьПрацівників;
            Adresa = adresa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            List<Firma> firmi = new List<Firma>()
            {
                new Firma("IT-Solutions", new DateTime(2020, 10, 1), "IT", "Петренко Іван Васильович", 150, "Київ, вул. Хрещатик, 15"),
                new Firma("Marketing Expert", new DateTime(2018, 5, 12), "Маркетинг", "Сидоренко Олена Петрівна", 75, "Львів, вул. Привокзальна, 10"),
                new Firma("Food Delivery", new DateTime(2022, 2, 14), "Доставка їжі", "Іванов Андрій Сергійович", 30, "Одеса, вул. Дерибасівська, 20"),
                new Firma("Web Development", new DateTime(2019, 3, 8), "Розробка веб-сайтів", "Білоус Ольга Миколаївна", 60, "Харків, вул. Сумська, 45"),
                new Firma("Legal Consulting", new DateTime(2017, 11, 23), "Юридичні консультації", "Чорний Максим Олександрович", 40, "Дніпро, вул. Дзержинського, 1"),
            };

            Console.WriteLine("**Інформація про всі фірми:**");
            foreach (var firma in firmi)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми, які мають у назві слово 'Food':**");
            var firmiZFood = firmi.Where(f => f.NazvaFirmi.Contains("Food"));
            foreach (var firma in firmiZFood)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми, які працюють у галузі маркетингу:**");
            var marketingFirmi = firmi.Where(f => f.ProfilBiznesu == "Маркетинг");
            foreach (var firma in marketingFirmi)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми, які працюють у галузі маркетингу або IT:**");
            var marketingITFirmi = firmi.Where(f => f.ProfilBiznesu == "Маркетинг" || f.ProfilBiznesu == "IT");
            foreach (var firma in marketingITFirmi)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми з кількістю працівників більшою, ніж 100:**");
            var firmiZ100Pracivnikami = firmi.Where(f => f.KількістьПрацівників > 100);
            foreach (var firma in firmiZ100Pracivnikami)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми з кількістю працівників у діапазоні від 100 до 300:**");
            var firmiZ100_300Pracivnikami = firmi.Where(f => f.KількістьПрацівників >= 100 && f.KількістьПрацівників <= 300);
            foreach (var firma in firmiZ100_300Pracivnikami)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми, які знаходяться в Лондоні:**");
            var londonskiFirmi = firmi.Where(f => f.Adresa.Contains("Лондон"));
            foreach (var firma in londonskiFirmi)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми, в яких прізвище директора White:**");
            var whiteDirectorFirmi = firmi.Where(f => f.PIBDirektora.Contains("White"));
            foreach (var firma in whiteDirectorFirmi)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми, які засновані більше двох років тому:**");
            var firmiZDvokhRokivNzad = firmi.Where(f => (DateTime.Now - f.DataZasnuyvannya).TotalDays > 365 * 2);
            foreach (var firma in firmiZDvokhRokivNzad)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми з дня заснування яких минуло 123 дні:**");
            var firmiZ123Dniami = firmi.Where(f => (DateTime.Now - f.DataZasnuyvannya).TotalDays == 123);
            foreach (var firma in firmiZ123Dniami)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.WriteLine("**Фірми, в яких прізвище директора Black і мають у назві фірми слово 'White':**");
            var blackDirectorWhiteFirmi = firmi.Where(f => f.PIBDirektora.Contains("Black") && f.NazvaFirmi.Contains("White"));
            foreach (var firma in blackDirectorWhiteFirmi)
                Console.WriteLine($"Назва: {firma.NazvaFirmi}, Дата заснування: {firma.DataZasnuyvannya}, Профіль бізнесу: {firma.ProfilBiznesu}, ПІБ директора: {firma.PIBDirektora}, Кількість працівників: {firma.KількістьПрацівників}, Адреса: {firma.Adresa}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

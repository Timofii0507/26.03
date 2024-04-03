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
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми, які мають у назві слово 'Food':**");
            var firmiZFood = firmi.Where(f => f.NazvaFirmi.Contains("Food"));
            foreach (var firma in firmiZFood)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми, які працюють у галузі маркетингу:**");
            var marketingFirmi = firmi.Where(f => f.ProfilBiznesu == "Маркетинг");
            foreach (var firma in marketingFirmi)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми, які працюють у галузі маркетингу або IT:**");
            var marketingITFirmi = firmi.Where(f => f.ProfilBiznesu == "Маркетинг" || f.ProfilBiznesu == "IT");
            foreach (var firma in marketingITFirmi)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми з кількістю працівників більшою, ніж 100:**");
            var firmiZ100Pracivnikami = firmi.Where(f => f.KількістьПрацівників > 100);
            foreach (var firma in firmiZ100Pracivnikami)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми з кількістю працівників у діапазоні від 100 до 300:**");
            var firmiZ100Do300Pracivnikami = firmi.Where(f => f.KількістьПрацівників >= 100 && f.KількістьПрацівників <= 300);
            foreach (var firma in firmiZ100Do300Pracivnikami)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми, які знаходяться в Лондоні:**");
            var londonskiFirmi = firmi.Where(f => f.Adresa.Contains("Лондон"));
            foreach (var firma in londonskiFirmi)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми, в яких прізвище директора White:**");
            var whiteDirektoriFirmi = firmi.Where(f => f.PIBDirektora.Split(' ').Last().ToLower() == "white");
            foreach (var firma in whiteDirektoriFirmi)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми, які засновані більше двох років тому:**");
            var davnoZasnovaniFirmi = firmi.Where(f => DateTime.Now - f.DataZasnuyvannya > TimeSpan.FromDays(365 * 2));
            foreach (var firma in davnoZasnovaniFirmi)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми з дня заснування яких минуло 123 дні:**");
            var dniFirmi = firmi.Where(f => (DateTime.Now - f.DataZasnuyvannya).Days == 123);
            foreach (var firma in dniFirmi)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n**Фірми, в яких прізвище директора Black і мають у назві фірми слово 'White':**");
            var blackWhiteFirmi = firmi.Where(f =>
                f.PIBDirektora.Split(' ').Last().ToLower() == "black" &&
                f.NazvaFirmi.Contains("White"));
            foreach (var firma in blackWhiteFirmi)
            {
                Console.WriteLine($"Назва: {firma.NazvaFirmi}");
                Console.WriteLine($"Дата заснування: {firma.DataZasnuyvannya}");
                Console.WriteLine($"Профіль бізнесу: {firma.ProfilBiznesu}");
                Console.WriteLine($"ПІБ директора: {firma.PIBDirektora}");
                Console.WriteLine($"Кількість працівників: {firma.KількістьПрацівників}");
                Console.WriteLine($"Адреса: {firma.Adresa}");
                Console.WriteLine("----------------------------------");
            }

            Console.ReadKey();
        }
    }
}

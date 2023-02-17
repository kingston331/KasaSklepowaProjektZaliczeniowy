using System;

namespace KasaSklepowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w sklepie! Oto nasza oferta produktów: ");
            string[] produkty = { "Masło Extra", "Chleb wiejski", "Makaron Babuni", "Dżem truskawkowy", "Kiełbasa myśliwska", "Szynka konserwowa", "Chipsy paprykowe", "Serek wiejski", "Sól kuchenna", "Cukier kryształ" };
            float[] ceny = { 6.5f, 4.5f, 9.2f, 8.1f, 29.0f, 22.0f, 6.0f, 3.5f, 2.7f, 3.2f };
            float koszyk = 0.0f;
            int[] wybory = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. {produkty[i]}, cena: {ceny[i]} zł");
            }
            char koniec = 'n';
            int wybor = 0;
            while (koniec != 'p')
            {
                Console.Write("Wybierz produkt, wpisując jego numer lub wciśnij 'p' aby zakończyć zakupy: ");
                koniec = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (koniec != 'p')
                {
                    wybor = koniec - '1';
                    if (wybor >= 0 && wybor < 10)
                    {
                        wybory[wybor]++;
                        koszyk += ceny[wybor];
                        Console.WriteLine($"Dodano {produkty[wybor]} do koszyka. Koszyk: {koszyk} zł");
                    }
                    else
                    {
                        Console.WriteLine("Nie ma takiego produktu!");
                    }
                }
            }
            float podatek = koszyk * 0.23f;
            Console.WriteLine("Paragon:");
            for (int i = 0; i < 10; i++)
            {
                if (wybory[i] > 0)
                {
                    Console.WriteLine($"{produkty[i]}, ilość: {wybory[i]}, cena: {ceny[i]} zł, łącznie: {ceny[i] * wybory[i]} zł");
                }
            }
            Console.WriteLine($"Łącznie: {koszyk} zł");
            Console.WriteLine($"VAT: {podatek} zł");
            Console.WriteLine($"Do zapłaty: {koszyk + podatek} zł");
            Console.WriteLine("Dziękujemy za zakupy!");
        }
    }
}
using ImdbListesi;
using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        List<Film> filmler = new List<Film>();
        string devam;

        do
        {
            Console.Write("Film ismini girin: ");
            string filmIsmi = Console.ReadLine();

            Console.Write("IMDB puanını girin (0-10 arası): ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani) || imdbPuani < 0 || imdbPuani > 10)
            {
                Console.Write("Geçerli bir IMDB puanı girin (0-10 arası): ");
            }

            filmler.Add(new Film(filmIsmi, imdbPuani));

            Console.Write("Başka bir film eklemek ister misiniz? (E/H): ");
            devam = Console.ReadLine().ToUpper();

        } while (devam == "E");

        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
        }

        Console.WriteLine("\nIMDB Puanı 4 ile 9 arasında olan Filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }

        Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
        foreach (var film in filmler)
        {
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }
    }
}


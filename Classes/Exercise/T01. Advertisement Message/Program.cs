using System;

namespace T01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phrases = new string[]
            {
                 "Excellent product.",
                 "Such a great product.",
                 "I always use that product.",
                 "Best product of its category.",
                 "Exceptional product.",
                 "I can't live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };

            var authors = new string[]
            {
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya",
                "Iva", 
                "Annie", 
                "Eva"
            };

            var city = new string[]
            {
                "Burgas", 
                "Sofia", 
                "Plovdiv", 
                "Varna", 
                "Ruse"
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               var chosenPhrase = RandomMessage(phrases, phrases.Length);
               var chosenEvent = RandomMessage(events, events.Length);
               var chosenAuthor = RandomMessage(authors, authors.Length);
               var chosenCity = RandomMessage(city, city.Length);

                Console.WriteLine($"{chosenPhrase} {chosenEvent} {chosenAuthor} – {chosenCity}.");
            }
        }

        static string RandomMessage(string[] collection, int end)
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(0, end);
            return collection[index];
        }
    }
}

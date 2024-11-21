using System;
namespace TemperatureConverterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User in my Converter!");

            Console.WriteLine("\n\tΚαλώς ήρθατε στην Εφαρμογή Μετατροπής Θερμοκρασίας!");
            Console.WriteLine("\t-----------------------------------------------------");
            Console.WriteLine("Επιλέξτε τον τύπο μετατροπής (Δώσε C ή F αντίστοιχα):  ");
            Console.WriteLine("C - Μετατροπή από Κελσίου σε Φαρενάιτ");
            Console.WriteLine("F - Μετατροπή από Φαρενάιτ σε Κελσίου\n");
            Console.Write("Δώσε την επιλογή σου: ");

            string choice = Console.ReadLine()?.ToUpper();

            if (choice != "C" && choice != "F")
            {
                Console.WriteLine("Μη έγκυρη επιλογή! Τερματισμός εφαρμογής.");
                return;
            }

            // Ανάγνωση θερμοκρασίας
            Console.Write("Εισάγετε την τιμή της θερμοκρασίας: ");
            bool input = double.TryParse(Console.ReadLine(), out double temperature);

            if (!input)
            {
                Console.WriteLine("Μη έγκυρη θερμοκρασία! Τερματισμός εφαρμογής.");
                return;
            }

            // Εκτέλεση μετατροπής
            double convertedTemperature;
            if (choice == "C")
            {
                // Κελσίου σε Φαρενάιτ: F = C × 9 / 5 + 32
                convertedTemperature = temperature * 9 / 5 + 32;
                Console.WriteLine($"{temperature} βαθμοί C ισούται με {convertedTemperature:F2} βαθμοί F");
            }
            else
            {
                // Φαρενάιτ σε Κελσίου: C = (F - 32) × 5 / 9
                convertedTemperature = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature} βαθμοί F ισούται με {convertedTemperature:F2} βαθμοί C");
            }

            Console.WriteLine("\nΕυχαριστώ που χρησιμοποιήσατε την εφαρμογή μου!");

        }   
    
    }
}

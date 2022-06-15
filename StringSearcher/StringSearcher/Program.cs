using System;
using System.Text.RegularExpressions;

namespace StringSearcher
{
    public class Program
    {
        static StringSearcher stringSearcher;
        public static void Main()
        {
            List<string> strings = new List<string>() {"qwertyu", "asdfgh", "zxcvb", "88005553535", "asdf54321qwerty", "90210"};
            string pattern;

            Console.WriteLine("Список строк");
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine($"{i + 1}. \"{strings[i]}\"");
            }

            Console.Write("Поиск цифр - 1, поиск букв - 2: ");
            if (Console.ReadLine() == "1")
            {
                pattern = @"^[a-z]+$";
                Console.WriteLine("Происходит поиск букв");
            }
            else
            {
                pattern = @"^\d+$";
                Console.WriteLine("Происходит поиск цифр");
            }

            stringSearcher = new();
            stringSearcher.Done += OnDone;

            stringSearcher.Search(strings, pattern);
            Console.WriteLine("Поиск завершен");
        }

        static void OnDone(object obj, FoundEventArgs arguments)
        {
            Console.WriteLine($"Строка \"{arguments.FoundedString}\" под номером {arguments.Position} совпадает.");
            Console.Write("Хотите ли вы продолжить? (д/н): ");
            if (Console.ReadLine() == "н")
            {
                stringSearcher.Done -= OnDone;
            }
        }
    }
}

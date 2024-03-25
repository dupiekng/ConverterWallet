using System;

namespace Lessons
{
    public class Program
    {
        private static float _dollarsRate = 92.61f;
        private static float _rubblesRate = 0.011f;

        private static void Main(string[] _)
        {
            Console.Title = "Обменник валют";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Greetings();
            UserInput();

            Console.ReadKey();
        }

        private static void Greetings()
        {
            Console.WriteLine("Добро пожаловать в обменник валют!");
            Console.WriteLine("\nОперации:\n\n\t1 - Обменять Доллары в Рубли.\n\t2 - Обменять Рубли в Доллары.");
            Console.Write("\nВыберите операцию: ");
        }

        private static void UserInput()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            UserInputOperation(userInput);
        }

        private static void UserInputOperation(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    CurrencyConversion(_dollarsRate, "Долларов", "Рубли");
                    break;

                case 2:
                    CurrencyConversion(_rubblesRate, "Рубли", "Долларов");
                    break;

                default:
                    Console.WriteLine("\nВведена неверная операция.");
                    break;
            }
        }

        private static void CurrencyConversion(float exchangeRates, string operationText, string operationText2)
        {
            Console.Write($"\nВведите желаемое количество {operationText} для конвертации в {operationText2}: ");
            double userInputMoney = Convert.ToDouble(Console.ReadLine());
            userInputMoney *= exchangeRates;

            Console.WriteLine($"\nИтоговая сумма составила: {Math.Round(userInputMoney, 2)} {operationText2}.");
        }
    }
}
// 1) Корректно переименовать переменные и методы.
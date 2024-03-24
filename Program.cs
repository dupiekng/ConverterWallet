using System;

namespace Lessons
{
    public class Program
    {

        private static float _dollarsRate = 92.61f;
        private static float _rubblesRate = 0.011f;

        private static void Main(string[] args)
        {
            Console.Title = "Обменник валют";

            Console.WriteLine("Добро пожаловать в обменник валют!");
            Console.WriteLine("1 - Обменять доллары в рубли\n2 - Обменять рубли в доллары.");
            Console.Write("Выберите команду: ");
            
            int userInput = Convert.ToInt32(Console.ReadLine());
            UserInputOperation(userInput);

            Console.ReadKey();
        }

        private static void UserInputOperation(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.Write("Введите желаемое количество долларов для конвертации в рубли: ");
                    double userInputDollars = Convert.ToDouble(Console.ReadLine());
                    userInputDollars *= _dollarsRate;

                    Console.WriteLine($"Итоговая сумма составила: {Math.Round(userInputDollars, 2)} рублей.");
                    break;

                case 2:
                    Console.Write("Введите желаемое количество рублей для конвертации в доллары: ");
                    double userInputRubbles = Convert.ToDouble(Console.ReadLine());
                    userInputRubbles *= _rubblesRate;

                    Console.WriteLine($"Итоговая сумма составила: {Math.Round(userInputRubbles, 2)} рублей.");
                    break;

                default:
                    Console.WriteLine("\nВведена неверная операция.");
                    break;
            }
        }
    }
}

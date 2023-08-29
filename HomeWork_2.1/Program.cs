using System;

class Program
{
    static void Main(string[] args)
    {
        float number = ReadFloatFromUser();
        Console.WriteLine("Введенное число: " + number);
    }

    static float ReadFloatFromUser()
    {
        string input;
        float number;
        bool success = false;

        do
        {
            Console.Write("Введите дробное число: ");
            input = Console.ReadLine();

            success = float.TryParse(input, out number);

            if (!success)
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            }
        }
        while (!success);

        return number;
    }
}
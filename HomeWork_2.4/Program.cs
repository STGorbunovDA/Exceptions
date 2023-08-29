using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Введите строку: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    throw new Exception("Пустые строки вводить нельзя");

                Console.WriteLine("Вы ввели: " + input);
                break; // если введена непустая строка, выходим из цикла
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
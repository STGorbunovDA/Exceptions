using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Запрос данных у пользователя
            Console.WriteLine("Введите данные в следующем порядке, разделенные пробелом:");
            Console.WriteLine("Фамилия Имя Отчество Дата_рождения Номер_телефона Пол (f/m)");

            string input = Console.ReadLine();

            // Разделение введенных данных
            string[] data = input.Split(' ');

            // Проверка количества введенных данных
            if (data.Length != 6)
                throw new ArgumentException("Неверное количество данных.");

            // Извлечение параметров из введенных данных
            string surname = data[0];
            string name = data[1];
            string patronymic = data[2];
            DateTime birthDate = ParseBirthDate(data[3]);
            uint phoneNumber = ParsePhoneNumber(data[4]);
            char gender = ParseGender(data[5]);

            // Создание строки для записи в файл
            string record = $"{surname} {name} {patronymic} {birthDate:dd.MM.yyyy} {phoneNumber} {gender}";

            // Запись строки в файл
            using (StreamWriter writer = new StreamWriter($"{surname}.txt", true))
            {
                writer.WriteLine(record);
            }//Dispose() || writer.Close()

            Console.WriteLine("Данные успешно записаны в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
        }

        Console.ReadLine();
    }

    static DateTime ParseBirthDate(string input)
    {
        DateTime birthDate;
        if (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
            throw new ArgumentException("Неверный формат даты рождения.");

        return birthDate;
    }

    static uint ParsePhoneNumber(string input)
    {
        uint phoneNumber;
        if (!uint.TryParse(input, out phoneNumber))
            throw new ArgumentException("Неверный формат номера телефона.");

        return phoneNumber;
    }

    static char ParseGender(string input)
    {
        if (input.Length != 1 || (input[0] != 'f' && input[0] != 'm'))
            throw new ArgumentException("Неверное значение пола.");

        return input[0];
    }
}
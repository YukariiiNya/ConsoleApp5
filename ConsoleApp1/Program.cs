using System;

class StringComparisonDemo
{
    static void Main(string[] args)
    {
        // Ввод строк пользователем
        Console.WriteLine("Введите первую строку:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        string str2 = Console.ReadLine();

        Console.WriteLine("Введите третью строку (часть текста для проверки):");
        string str3 = Console.ReadLine();

        // 1. Compare() — лексикографическое сравнение строк
        int compareResult = String.Compare(str1, str2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"Compare (OrdinalIgnoreCase): {compareResult}");

        // 2. CompareOrdinal() — побайтовое сравнение
        int ordinalResult = String.CompareOrdinal(str1, str2);
        Console.WriteLine($"CompareOrdinal: {ordinalResult}");

        // 3. Equals() — проверка на равенство
        bool equalsResult = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"Equals (OrdinalIgnoreCase): {equalsResult}");

        // 4. IndexOf() — поиск индекса первого вхождения
        int indexOfResult = str1.IndexOf(str3);
        if (indexOfResult != -1)
        {
            Console.WriteLine($"IndexOf '{str3}': {indexOfResult}");
        }
        else
        {
            Console.WriteLine($"'{str3}' не найдено в '{str1}'.");
        }

        // 5. Contains() — проверка на наличие подстроки
        bool containsResult = str1.Contains(str3);
        Console.WriteLine($"Contains '{str3}': {containsResult}");

        // 6. Оператор ==
        bool equalityOperatorResult = str1 == str2;
        Console.WriteLine($"Operator ==: {equalityOperatorResult}");

        // 7. Оператор !=
        bool inequalityOperatorResult = str1 != str3;
        Console.WriteLine($"Operator !=: {inequalityOperatorResult}");

        // Завершающее сообщение
        Console.WriteLine("Программа завершена!");
    }
}

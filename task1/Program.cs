// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Promt("Введите пятизначное число: ");


if (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}
else if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


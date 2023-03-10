// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Promt("Введите число N: ");
int count = 1;
while (count <= number)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}
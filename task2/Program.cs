// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84

// A(7, -5, 0); B(1, -1, 9)-> 11.53

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double x1 = Promt("Введите координату точки X1: ");
double y1 = Promt("Введите координату точки Y1: ");
double z1 = Promt("Введите координату точки Z1: ");

double x2 = Promt("Введите координату точки X2: ");
double y2 = Promt("Введите координату точки Y2: ");
double z2 = Promt("Введите координату точки Z2: ");

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(Math.Round(result, 2));

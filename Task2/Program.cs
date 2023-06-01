// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
//  y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadInt(string text)//Функция вывода текста и сохранение введённого числа.
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double iks(int b1, int k1, int b2, double k2)//Функция подсчёта координаты X.
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double igr(double k1, double x, double b1)//Функция подсчёта координаты Y.
{
    double y = (k1 * x) + b1;
    return x;
}

int b1 = ReadInt("Введите число b1: ");
int k1 = ReadInt("Введите число k1: ");

int b2 = ReadInt("Введите число b1: ");
double k2 = ReadInt("Введите число k1: ");

double x=iks(b1,k1,b2,k2);
double y=igr(k1,x,b1);

Console.WriteLine($"Координата X={x}");
Console.WriteLine($"Координата Y={y}");

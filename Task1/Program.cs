// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//--------------------------------------------------------------------

Console.Write("Укажите колличество чисел, для сравнения:  ");
int element = int.Parse(Console.ReadLine()!);
int sum=0;
int[] Array = new int[element];

for (int i=0; i< Array.Length; i++)
{
        Array[i] = int.Parse(Console.ReadLine()!);
}

void PrintArray(int[] array)
{
    Console.Write("");
    for (int i=0; i<Array.Length; i++)
    {
        Console.Write($"{Array[i]}, " );
    }
}

for (int i=0; i<element; i++)
{
    if (Array[i]<0) 
    sum+=1;
}

PrintArray(Array);
Console.WriteLine();
Console.Write($"Колличество всех отрицательных чисел равна : {sum}");



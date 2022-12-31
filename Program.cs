// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int[] CreateArray(int size)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i == array.Length - 1) Console.Write("]");
        else Console.Write(", "); 
    }
}

void SumNumGrearZero(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine($"\nКоличество чисел больше 0: {count}");
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
SumNumGrearZero(myArray);

*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение точки b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение точки k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение точки b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение точки k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);


Console.WriteLine($"Пересечение в точке -> ({x};{y})");
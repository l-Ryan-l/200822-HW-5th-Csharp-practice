/* 
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] FillArray(int limitOfArray)
{
    int[] array = new int[limitOfArray];
    var rnd = new Random();
    for (int i = 0; i < limitOfArray; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
} 

int CheckEven (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.Write("Введите желаемую длину массива: ");
int limitOfArray = int.Parse(Console.ReadLine()!);

int[] array = FillArray(limitOfArray);

Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Количество четных чисел в массиве: " + CheckEven(array));
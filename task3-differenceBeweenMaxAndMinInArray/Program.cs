/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3, 7, 22, 2, 78] -> 76 
*/

void FillArray (double[] array)
{
    Console.Write("Введите начальное значение диапазона: ");
    int begin = int.Parse(Console.ReadLine()!);
    Console.Write("Введите конечное значение диапазона: ");
    int end = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(begin, end + 1);
}

double FindMax (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
    return max;   
}

double FindMin (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
    return min;   
}

Console.Write("Укажите кол-во элементов в массиве: ");
int limit = int.Parse(Console.ReadLine()!);
double[] array = new double[limit];

FillArray(array);
Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");

Console.WriteLine($"Максимальное число массива = {FindMax(array)}");
Console.WriteLine($"Минимальное число массива = {FindMin(array)}");
Console.WriteLine($"Разница между максимальным и минимальным эллементом массива = {FindMax(array) - FindMin(array)}.");

/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


void FillArray (int[] array)
{
    Console.Write("Введите начальное значение диапазона: ");
    int begin = int.Parse(Console.ReadLine()!);;
    Console.Write("Введите конечное значение диапазона: ");
    int end = int.Parse(Console.ReadLine()!);;
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(begin, end + 1);
}

int SummOfOddPositions (int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)
        summ = summ + array[i];
    return summ;
}

Console.Write("Укажите кол-во элементов в массиве: ");
int limit = int.Parse(Console.ReadLine()!);
int[] array = new int[limit];

FillArray(array);
Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма элементов массива на нечетных позициях = {SummOfOddPositions(array)}.");

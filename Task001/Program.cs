// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int[] FillArray(int arrLenght, int minValue, int maxValue)
{
    int[] array = new int[arrLenght];
    for (int i =0; i < arrLenght; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    Console.WriteLine (string.Join (", ", array));
    return  array;
}
int countEven (int [] array)
{
    int count = 0;
    int[] arr = array;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
int[] array = FillArray(20, 100, 1000);
int result = countEven(array);
Console.WriteLine("Количество четных чисел в данном массиве = " + result);
// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

Console.Clear();
double[] FillArray(int arrLenght, int minValue, int maxValue)
{
    double[] array = new double[arrLenght];
    Random rand = new Random();
    for (int i =0; i < arrLenght; i++)
    {
        array[i] = rand.Next(minValue, maxValue) + rand.NextDouble();
    }
    Console.WriteLine (string.Join (", ", array));
    return  array;
}
double max (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double min (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double[] array = FillArray(5, 1, 10);
double maxx = max (array);
double minn = min (array);
double result = maxx - minn;
Console.WriteLine("Разница между максимальным и минимальным элементами массива вещественных чисел = " + result);
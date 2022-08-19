// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

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
int sumOdd (int[] array)
{
    int sum = 0;
    int[] arr = array;
    for (int i = 1; i < arr.Length; i++, i++)
    {
        sum += array[i];
    }
    return sum;
}
int[] array = FillArray(10, 1, 100);
int result = sumOdd(array);
Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях = " + result);
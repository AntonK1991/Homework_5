// Задача 38 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

int Input()
{
    Console.Write("Введите количество элементов массива: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

double[] CreateMassive(int n)
{
    double[] array = new double[n];
    return (array);
}

double[] RandomFillMassive(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble(); 
    }
    return (array);
}

double[] PrintMassive(double[] array)
{
    System.Console.WriteLine("Элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    return array;
}

double MaxMinNumber(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double result = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементом: " + result);
    return result;
    
}

MaxMinNumber(PrintMassive(RandomFillMassive(CreateMassive(Input()))));

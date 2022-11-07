// Задача 34: 
// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

int[] CreateMassive(int n)
{
    int[] array = new int[n];
    return (array);
}

int[] RandomFillMassive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return (array);
}

int [] PrintMassive(int[] array)
{
    System.Console.WriteLine ("Элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine ();
    return array;
}

void NumsCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine("Количество четных элементов в массиве - " + count);
}

Console.Write("Введите количество элементов массива: ");
int input = Convert.ToInt32(Console.ReadLine());
NumsCount(PrintMassive(RandomFillMassive(CreateMassive(input))));


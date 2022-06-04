
//Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите строк: ");
 int a = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите столбцов: ");
 int b = int.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
    return array;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] arrayResult = GetArray(a, b);
PrintArray(arrayResult);

void FindElement()
{
Console.WriteLine("Введите индексы элемента через пробел: ");
 int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
 int x = arr[0];
 int y = arr[1];
  if (x > a || y > b)
    {
        Console.WriteLine("Элемента с таким индексом нет!");
    }
    else
    {
        int i = arr[0];
        int j = arr[1];
        
        Console.Write($"Значение выбранного элемента: {arrayResult[i,j]}");
    }
}
 


FindElement();

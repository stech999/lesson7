// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7]->такого числа в массиве нет [1,7] -это позиция элемента 1 - строка, 7 - столбец

Console.Clear();

int Rows = Prompt("Введите количество столбцов массива: ");
int Columns = Prompt("Введите количество строк массива: ");

int[,] array = GetArray(Rows, Columns);
PrintArray(array);

CheckArray(array);

void CheckArray(int[,] array) // Сравнение элементов
{
    Rows = Prompt("Введите строку элемента: ");
    Columns = Prompt("Введите столбец элемента: ");

    int a = Rows - 1;
    int b = Columns - 1;

    if (Rows <= 0 || Rows > array.GetLength(0) || Columns <= 0 || Columns > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет.");
    }
    else
    {
        Console.WriteLine($"Найденный элемент в массиве равен: {array[a, b]}");
    }
}

int Prompt(string message) // Считываем строку
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n) // создание массива в пределах пользовательского ввода
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10); // рандомное заполнение массива в переделах от 1 до 10
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // Показываем пользвателю массив
{
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
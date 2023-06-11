// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[,] CreateArray(int m, int n)
{
    int[,] Element = new int[m, n];

    for (int i = 0; i < Element.GetLength(0); i++)
    {
        for (int j = 0; j < Element.GetLength(1); j++)
        {
            Element[i, j] = new Random().Next(1, 10);
        }
    }
    return Element;
}

void PrintArray(int[,] ar2)
{
    for (int k = 0; k < ar2.GetLength(0); k++)
    {
        for (int l = 0; l < ar2.GetLength(1); l++)
        {
            Console.Write($"{ar2[k, l]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticElements(int[,] Elements, double[] SumEl)
{

    for (int i = 0; i < Elements.GetLength(1); i++)
    {
        double sum = 0;

        for (int j = 0; j < Elements.GetLength(0); j++)
        {
            sum = sum + Elements[j, i]; // j - столбец i - строка
        }

        double Value = 0;

        Value = sum / Elements.GetLength(0);

        Console.WriteLine($"Сумма {i + 1} столбца = {sum}, средне-арифметические значение столбца: {Math.Round(Value, 3)}");// 
    }

}

int str = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
int[,] elements = CreateArray(str, col);

double[] SumEl = new double[elements.GetLength(1)];

PrintArray(elements);
Console.WriteLine();

ArithmeticElements(elements, SumEl);
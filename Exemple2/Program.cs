// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int [m, n];
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}
void PositionElement(int[,] matr, int x, int y)
{
    if (x >= matr.GetLength(0) || y >= matr.GetLength(1))
    {
        System.Console.Write("Такого числа нет ");
    }
    else 
    {
        System.Console.Write(matr[x,y] + " ");
    }
}
int m = ReadInt("Введите количетсво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
int x = ReadInt("Введите строку элемента ");
int y = ReadInt("Введите столбец элемента ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
PositionElement(myMatrix, x, y);

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//Решение:

/*

Console.WriteLine("Задаем двумерный массив, упорядочиваем элементы по убыванию каждой строки двумерного массива.");


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное занчение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] massiv = new int[m, n];


void NewMassiv(int[,] x){
    for (int i = 0; i < x.GetLength(0); i++){
        for (int j = 0; j < x.GetLength(1); j++){
            x[i,j] = Convert.ToInt32(new Random().Next(min, max));
        }
    }       
}


void PrintMassiv(int[,] y)
{
    for (int i = 0; i < y.GetLength(0); i++){
        for (int j = 0; j < y.GetLength(1); j++){
            Console.Write($"{y[i, j]} ");
            if (j < y.GetLength(1)-1)
                Console.Write(" ; ");}
        Console.WriteLine("");
    }
}


void DescendingMassiv(int [,]z)
{
    Console.Write("");
    Console.WriteLine("Упорядоченные элементы по убыванию каждой строки двумерного массива:");

        for (int i = 0; i < z.GetLength(0); i++)
        {
            for (int j = 0; j < z.GetLength(1); j++)
            {
                for (int b = 0; b < z.GetLength(0) - 1; b++)
                {
                    if (z[i, b] < z[i, b + 1])
                    {
                    int temp = z[i, b + 1];
                    z[i, b + 1] = z[i, b];
                    z[i, b] = temp;
                    }
                }
            }
        }
}


NewMassiv(massiv);
PrintMassiv(massiv);
DescendingMassiv(massiv);
PrintMassiv(massiv);

*/

/*

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


// Решение:

/*

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон случайных чисел: от 1 до ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] massiv = new int[m, n];


void NewMassiv(int[,] x){
    for (int i = 0; i < x.GetLength(0); i++){
        for (int j = 0; j < x.GetLength(1); j++){
            x[i,j] = Convert.ToInt32(new Random().Next(1, max));
        }
    }       
}


void PrintMassiv(int[,] y)
{
    for (int i = 0; i < y.GetLength(0); i++)
    {
        Console.WriteLine(" ");
        for (int j = 0; j < y.GetLength(1); j++){
            
            Console.Write($"{y[i, j]} ");
            
            if (j < y.GetLength(1)-1){
                Console.Write("");
            }
        }
         Console.WriteLine(" ");
    }
}


NewMassiv(massiv);
PrintMassiv(massiv);


int minSumLine = 0;
int sumLine = RowSum(massiv, 0);
for (int i = 1; i < massiv.GetLength(0); i++)
{
  int tempSumLine = RowSum(massiv, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine("");
Console.WriteLine($"Строка № {minSumLine+1} содержит наименьшее количество элементов ({sumLine})!");


int RowSum(int[,] massiv, int i)
{
  int sumLine = massiv[i,0];
  for (int j = 1; j < massiv.GetLength(1); j++)
  {
    sumLine += massiv[i,j];
  }
  return sumLine;
}

*/


/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// Решение:

/*

Console.WriteLine("Программа заполнения массива спирально, начиная с 1.");

Console.Write("Введите размер квадратного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newMassiv = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;


while (temp <= newMassiv.GetLength(0) * newMassiv.GetLength(1))
{
  newMassiv[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < newMassiv.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= newMassiv.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > newMassiv.GetLength(1) - 1)
    j--;
  else
    i--;
}


void PrintMassiv (int[,] x)
{
  for (int i = 0; i < x.GetLength(0); i++)
  {
    for (int j = 0; j < x.GetLength(1); j++)
    {
      if (x[i,j] / 10 <= 0)
      Console.Write($" {x[i,j]} ");

      else Console.Write($"{x[i,j]} ");
    }
    Console.WriteLine();
  }
}

PrintMassiv(newMassiv);

*/



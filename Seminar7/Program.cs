/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

// Решение
       



Console.WriteLine("Программа выдаст массив размером MxN заполненный случайными вещественными числами.");
Console.Write("Введите кол-во строк (значение M):");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов (значение N):");
int n= Convert.ToInt32(Console.ReadLine());

double[,] massiv = new double [m,n]; 

void NewMassiv(double[,] x){
    for (int i = 0; i < x.GetLength(0); i++){
        for (int j = 0; j < x.GetLength(1); j++){
            x[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }       
}
void PrintMassiv(double[,] y)
{
    for (int i = 0; i < y.GetLength(0); i++){
        for (int j = 0; j < y.GetLength(1); j++){
            Console.Write($"{y[i, j]} ");
            if (j < y.GetLength(1)-1)
                Console.Write(" ; ");}
        Console.WriteLine("");
    }
}

NewMassiv(massiv);
PrintMassiv(massiv);





/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого числа в массиве нет
1,2 -> 2

*/

// Решение


/*

Console.WriteLine("Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

Console.Write("Введите искомое значение, номер строки:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое значение, номер столбца:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] massiv = new int [10,10];

void NewMassiv(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {        
        for (int j = 0; j < x.GetLength(1); j++)
        {
            x [i,j] = new Random().Next(-10, 10);
        }   
    }
}

void PrintMassiv(int[,] y)
{
    Console.WriteLine("Создан массив из случайных чисел:");
    for (int i = 0; i < y.GetLength(0); i++)
    {
        for (int j = 0; j < y.GetLength(1); j++)
        {
            Console.Write(y[i,j] + " ");
            if (j < y.GetLength(1)-1)
            {
                Console.Write(" ; ");
            }
        }   
        Console.WriteLine(""); 
    }
    if (m > massiv.GetLength(0) || n > massiv.GetLength(1))
    {
        Console.WriteLine("Элемент отсутствует! В массиве <10> строк; <10> столбцов.");
    }
    else
    {
        Console.WriteLine($"Значение строки <{m}> столбца <{n}> = {massiv[m-1,n-1]}!");
    }
}

NewMassiv(massiv);
PrintMassiv(massiv);

*/



/*

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/


//Решение


/*

Console.Write("После ввода значений MxN выдает двумерный массив из целых чисел. Находит среднее арифметическое значение элементов в каждом столбце.");

Console.Write("Введите количество строк (М):");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (N):");
int n = Convert.ToInt32(Console.ReadLine());

int [,] massiv = new int [n,m];

void NewMassiv(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {        
        for (int j = 0; j < x.GetLength(1); j++)
        {
        x [i,j] = new Random().Next(-10, 10);
        }   
    }
}

void PrintMassiv(int[,] y)
{
    Console.WriteLine("Создан массив из случайных чисел:");
    for (int i = 0; i < y.GetLength(0); i++)
    {
        for (int j = 0; j < y.GetLength(1); j++)
        {
            Console.Write(y[i,j] + " ");
            if (j < y.GetLength(1)-1)
            {
                Console.Write(" ; ");
            }
        }   
        Console.WriteLine(""); 
    }
}

void AverageСolumn (int[,] z)
{
    Console.WriteLine("Среднее арифметическое значение по столбцам:");
    for (int j = 0; j < z.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < z.GetLength(0); i++)
        {
            average = (average + z[i, j]);
        }
        average = average / m;
        Console.Write(average);
        if (j < z.GetLength(1)-1)
        {
        Console.Write(" ; ");
        }
    }
}

NewMassiv(massiv);
PrintMassiv(massiv);
AverageСolumn(massiv);

*/


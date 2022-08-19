// Выполнение домашнего задания к семинару "Знакомство с языками программирования". Урок 1. "Знакомство с языком программирования С#" 


/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
 
// Решение:

Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
int num1;
int num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max=" + num1);
    Console.WriteLine("min=" + num2);
}
else
{
    Console.WriteLine("max=" + num2);
    Console.WriteLine("min=" + num1);
}

 

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

// Решение:
 
Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
int num1;
int num2;
int num3;
int max;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
max = num1;
}
else
{
max = num2;
}
    if (max > num3)
    {
    max = max;
    }
    else
    {
    max = num3;
    }
Console.WriteLine("max = " + max);



/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

// Решение:

Console.WriteLine("Программа, которая на вход принимает число и выдаёт, является ли число чётным");
int num1;
int num2;
int num3;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

if ((num1 % 2) == 0)
{
 Console.WriteLine(num1 + " ->" + " Да");
}
else
{
Console.WriteLine(num1 + " ->" + " Нет");
}
   if ((num2 % 2) == 0)
    {
    Console.WriteLine(num2 + " ->" + " Да");
    }
    else
   {
    Console.WriteLine(num2 + " ->" + " Нет");
   }
      if ((num3 % 2) == 0)
      {
       Console.WriteLine(num3 + " ->" + " Да");
      }
      else
      {
       Console.WriteLine(num3 + " ->" + " Нет");
      }


/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

// Решение:

Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
int numA = 1;
Console.Write("Введите число (N):");
int numN;
numN = Convert.ToInt32(Console.ReadLine());

while (numA < numN)
{
   numA = numA + 1;
 
if (numA%2 == 0)            
{
   Console.Write(numA + ";");
}
}


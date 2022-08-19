// Выполнение домашнего задания к семинару "Знакомство с языками программирования". Урок 1. "Знакомство с языком программирования С#" 


// Добавить задачу 2.















































































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

if (num1>num2)
{
 max=num1;
}
else
{
 max=num2;
}
   if (max>num3)
   {
    max=max;
   }
   else
   {
    max=num3;
   }

Console.WriteLine("max = " + max);


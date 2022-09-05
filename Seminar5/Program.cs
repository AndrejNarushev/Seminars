

// !!! В решениях присутствуют разные конструкции создания массива PrintArray (формирование , после значений и ] после окончания массива), а также разные конструкции вывода информации на консоль (через $ и + (Console.......)). !!! сделано сознательно в целях закрепления информации. !!!



/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// Решение:

/*
Console.WriteLine("Программа которая задает массив заполненный случайными положительными трёхзначными числами, показывает количество чётных чисел в массиве.");
Console.Write("Задайте кол-во цифр в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
if(size>0)
{
void RandomArray(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }

}

void PrintArray(int[] numbers)
{
    Console.Write("Создан случайный массив: ");
    Console.Write("[");
    for(int j=0; j < size; j++)
    {
        Console.Write(numbers[j]);
           if (j < size-1)
           {
            Console.Write(",");
           }
           else                                           
           {
            Console.Write("]");
            }
    }
    Console.WriteLine("");
}

int[] numbers = new int[size];
RandomArray(numbers);
PrintArray(numbers);


int count = 0;
for (int i = 0; i < size; i++)
if (numbers[i] % 2 == 0)
count++;
Console.WriteLine($"Массив состоит из {size} чисел, в т.ч. количество чётных {count} !");
}

else
{ 
    Console.Write("Введенное значение не соответствует условию задачи! Попробуте еще раз.");
}
*/



/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

//Решение

/*
Console.WriteLine("Программа задает одномерный массив, заполненный случайными числами, показывает сумму элементов, стоящих на нечётных позициях.");
Console.Write("Задайте кол-во цифр в массиве:");
int size = Convert.ToInt32(Console.ReadLine());

void RandomArray(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-1000,1000);
    }

}

void PrintArray (int[] numbers)
{
   Console.WriteLine("Создан случайный массив: ");
   Console.Write("[");
    for(int j=0; j < size; j++)
    {
        Console.Write(numbers[j]);
           if (j < size-1)
           {
            Console.Write(",");
           }
           else
           {
            Console.Write("]");
            }
    }
    Console.WriteLine("");
}

int [] numbers=new int[size];
RandomArray (numbers);
PrintArray (numbers);

int sum=0;
for (int b = 0; b<size; b+=2)
{
        sum =sum+numbers[b];
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях = "+ sum);
*/




/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// Решение


/*
Console.WriteLine("Программа задает массив вещественных чисел, находит разницу между максимальным и минимальным элементов массива.");
Console.Write("Задайте кол-во цифр в массиве:");
int size = Convert.ToInt32(Console.ReadLine());

void RandomArray(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-1000,1000);
    }

}

void PrintArray (int[] numbers)
{
   Console.WriteLine("Создан случайный массив вещественных чисел: ");
   Console.Write("[ ");
   for (int j = 0; j < size; j++)
   {
     Console.Write(numbers[j]+" ");
   }
     Console.WriteLine("]");
}

int [] numbers=new int[size];
RandomArray (numbers);
PrintArray (numbers);


double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int b = 0; b < size; b++)
{
    if (numbers[b] > max)
        {
            max = numbers[b];
        }
    if (numbers[b] < min)
        {
            min = numbers[b];
        }
}
double r = max-min;

Console.WriteLine("Максимальное значение = "+max+": ");
Console.WriteLine($"Минимальное значение = {min}: ");
Console.WriteLine("Разница между максимальным и минимальным значением = "+r);
*/



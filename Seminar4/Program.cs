//
/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/


// Решение:


/*
Console.WriteLine("Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.Write("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
    
if (a >0 && b>0){   
    int Step(int a, int b)
    {
        int c = 1;
        for(int i=1; i <= b; i++)
        {
            c = c * a;
        }
        return c;
    }
    int r = Step(a, b);
    Console.WriteLine($"Число {a} в натуральной степени {b} = {r}!");
    string rs = Convert.ToString(r);
    Console.Write("");
}
else
{
    Console.WriteLine("Введенные данные не соответствуют заданию!");
}
*/



/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/


// Решение:


/*
Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int S(int a){
int a1 = Convert.ToString(a).Length; 
    int x1 = 0;
    int x2 = 0;

    for (int i = 0; i < a1; i++)
    {
      x1 = a - a % 10;
      x2 = x2 + (a - x1);
      a = a / 10;
    }
   return x2;
}
int summa = S(a);
Console.WriteLine("Сумма цифр = " + summa);
*/



/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


// Решение:


/*
Console.WriteLine("Программa, которая задаёт массив и выводит его на экран.");

Console.Write("Введите числа разделенные запятой (,): ");
Console.WriteLine("Окончание ввода нажмите Enter!");

string vvodstr = Console.ReadLine();
vvodstr = vvodstr + ",";  

string Str (string strx)
{
  string x = "";
  for (int i = 0; i < strx.Length; i++)
  {
    if (strx[i] != ' ') 
    {
      x += strx[i];
    }
  }
  return x;
}

int[] ArrayStr(string x)
{ 
  int[] arraystr1 = new int[1];    
  int j =0;
  for (int i = 0; i < x.Length; i++){
    string x1 = "";
    while (x[i] != ',' && i < x.Length){
      x1 += x[i];
      i++;
    }
    arraystr1[j] = Convert.ToInt32(x1);    
    if (i < x.Length-1){
      arraystr1 = arraystr1.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arraystr1;
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

string x = Str(vvodstr);
int[] arraystr1 =  ArrayStr(x);
PrintArry(arraystr1);
*/


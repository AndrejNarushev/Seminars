
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/

//Решение:

/*

Console.Write("Введите числа разделенные точкой (.): ");
Console.WriteLine("Окончание ввода нажмите Enter!");

string? vvodstr = Console.ReadLine();
vvodstr = vvodstr + ".";  

int[] ArrayStr(string x)
{ 
  int[] arraystr1 = new int[1];    
  int j = 0;
  for (int i = 0; i < x.Length; i++){
    string x1 = "";
    while (x[i] != '.' && i < x.Length){
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
  Console.Write("Введен массив [");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(",");
    }
  }
  Console.Write("]");
} 

void More (int[]arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if(arr[i] > 0 )
  { 
  count = count+1;
  }
}
Console.Write($"Количество чисел больше <0> введенных пользователем составляет: {count} числа(ел).");
}

string x = vvodstr;
int[] arraystr1 = ArrayStr(x);
PrintArry(arraystr1);
More(arraystr1);

*/



/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//Решение:

/*

Console.WriteLine("Программа пересечения двух прямых.");

double[,] coordinat = new double[2, 2];
void EnteringСoordinates(){
  for (int i = 0; i < coordinat.GetLength(0); i++)
  {
    Console.WriteLine($"Введите координаты {i+1}-й прямой:");
    for (int j = 0; j < coordinat.GetLength(1); j++)
    {
      if(j==0) Console.Write("Введите координаты k: ");
      else Console.Write($"Введите координаты b: ");
      coordinat[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] IntersectionPoint = new double[2];
double[] Result(double[,] coordinat)
{
  IntersectionPoint[0] = (coordinat[1,1] - coordinat[0,1]) / (coordinat[0,0] - coordinat[1,0]);
  IntersectionPoint[1] = IntersectionPoint[0] * coordinat[0,0] + coordinat[0,1];
  return IntersectionPoint;
}

void PrintResult(double[,] coordinat)
{
  if (coordinat[0,0] == coordinat[1,0] && coordinat[0,1] == coordinat[1,1]) 
  {
    Console.Write("Прямые равны");
  }
  else if (coordinat[0,0] == coordinat[1,0] && coordinat[0,1] != coordinat[1,1]) 
  {
    Console.Write("Прямые параллельны");
  }
  else 
  {
    Result(coordinat);
    Console.Write($"Точка пересечения прямых: ({IntersectionPoint[0]} ; {IntersectionPoint[1]})");
  }
}

EnteringСoordinates();
PrintResult(coordinat);

*/
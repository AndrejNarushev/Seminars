/* 
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/

// Решение:

/*
Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
Console.Write("Введите пятизначное число - ");
string a = Console.ReadLine();
int x= a.Length;
if (x != 5){
    Console.WriteLine("Введенное число не соответствует условию задачи!");
}
else{
    bool flag = true;
    for(int i = 0;i<=(x-1)/2;i++){
        if (a[i] != a[x-(i+1)]){
            flag=false;
            break;
        }
    }
    if (flag){
        Console.WriteLine("Число является палиндромом");
    }
    else{
    Console.WriteLine("Число не является палиндромом");
    }
}    

*/

/*
Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Решение:

/*
Console.WriteLine ("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
;
int x1 = Data("x");
int y1 = Data("y");
int z1 = Data("z");
int Data(string coorName){
    Console.Write ("Введите поочередно координаты (x, y, z) точки А:");
    return Convert.ToInt16(Console.ReadLine());
}
int x2 = Data2("x");
int y2 = Data2("y");
int z2 = Data2("z");
int Data2(string coorName){
    Console.Write ("Введите поочередно координаты (x, y, z) точки B:");
    return Convert.ToInt16(Console.ReadLine());
}

double Data3(double x1, double x2, double y1, double y2, double z1, double z2){
return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double DataF =  Math.Round (Data3(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние между точками =  {DataF}");

*/

/*
Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// Решение:
/*

Console.WriteLine ("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.Write("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
void Cub (){
if (num>=1){
for (int i = 1; i <= num; i++)
{
    int cubnum= Convert.ToInt32(Math.Pow(i,3));
    Console.WriteLine(cubnum);
}
}
else{
    Console.WriteLine("Введеное число не соответствует условиям задачи!");
}
}

Cub();

*/





	

		
		
/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""

*/

// Решение:

/*

// запрос данных
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}


// функция вычисления суммы
string SumMN(int M, int N)
{
 if(M>=N)return N.ToString();
 return M.ToString()+", "+SumMN(M+1,N).ToString();
}


//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}


Console.Clear();
Console.WriteLine("Задайте значения M и N. Программа, найдёт выведет все натуральные числа в промежутке от M до N");
int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
string res=(numM<numN)?(SumMN(numM, numN)):(SumMN(numN, numM)); 
PrintData("Натуральные числа в промежутке от <" + numM +"> до <" + numN + "> -> ''",res.ToString()+"''");

*/




/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// Решение

/*

// запрос данных
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}


// функция вычисления суммы
int SumMN(int M, int N)
{
 if(M>=N)return N;
 return M+SumMN(M+1,N);
}


//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}


Console.Clear();
Console.WriteLine("Задайте значения M и N. Программа, найдёт сумму натуральных элементов в промежутке от M до N.");
int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int res=(numM<numN)?(SumMN(numM, numN)):(SumMN(numN, numM)); 
PrintData("Cумма натуральных элементов в промежутке от <" + numM +"> до <" + numN + "> -> ", res.ToString());

*/


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
*/

// Решение:

/*

// запрос данных
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}


// вычисление функции Аккермана
int FunctionAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAkkerman(m - 1, 1);
  else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}


//Вывод результата
void PrintData(int M, int N, int X)
{
    Console.WriteLine($"m = {M}, n = {N} -> A(m,n) = "+X);
}


Console.Clear();
Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.");
int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int res = FunctionAkkerman(numM, numN);
PrintData(numM,numN,res);
// Console.WriteLine($"m = {numM}, n = {numN} -> A(m,n) = "+res);

*/






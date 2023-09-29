// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int SetNumber(string message)
// {
//     Console.WriteLine($"{message}");
//     string strNum = Console.ReadLine();
//     int num = 0;

//     if (int.TryParse(strNum, out num))
//     {
//         return num;
//     }

//     System.Console.WriteLine("неверный формат(((");
//     return SetNumber(message);
// }

// string PrintNumbers(int stop, int start)
// {
//     if (stop <= start)
//     {

//         return Convert.ToString(stop);
//     }

//     string str = Convert.ToString(stop) + " " + PrintNumbers(stop - 1, start);

//     return str;
// }

// int start = 1;

// int stop = SetNumber("Введите число N: ");

// Console.WriteLine(PrintNumbers(stop, start));




// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// // вызов функции "сумма чисел от M до N"
// void SumFromMToN(int m, int n)
// {
//     Console.Write(Sum(m - 1, n));
// }
// int Sum(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + Sum(m, n);
//         return res;
//     }
// }


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("N: ");
int N = Convert.ToInt32(Console.ReadLine());

Funct(M,N);

void Funct(int M, int N)
{
    Console.Write(Akk(M, N)); 
}

int Akk(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akk(M - 1, 1);
    }
    else
    {
        return (Akk(M - 1, Akk(M, N - 1)));
    }
}
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

int printAckermann(int m, int n)
{
    if (m == 0) return n + 1; 
    else if (n == 0) return printAckermann(m - 1, 1);
    else return printAckermann(m - 1, printAckermann(m, n - 1));
}
Console.WriteLine(printAckermann(M, N));

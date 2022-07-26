//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

string printNumber(int start, int end)
{
    if (start == end) 
    {
        return start.ToString();
    }
    return (start + ", " + printNumber(start + 1, end));
}
Console.WriteLine(printNumber(M, N));







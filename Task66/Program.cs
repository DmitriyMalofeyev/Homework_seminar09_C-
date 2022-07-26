// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M (наименьшее): ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N (наибольшее): ");
int N = Convert.ToInt32(Console.ReadLine());



int printNumber(int start, int end)
{
    if (start <= end) return (start + printNumber(start + 1, end));
    else return 0;
          
}
Console.WriteLine(printNumber(M, N));



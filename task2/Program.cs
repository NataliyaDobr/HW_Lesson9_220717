// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumElem(int m, int n)
{
    if (m > n)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return 0;
    }
    //System.Console.WriteLine(n);
    return SumElem(m+1,n)+m;
}

int numM = Promt("введите число M ");
int numN = Promt("введите число N, большее M ");

if (numN>numM) {
int resultSum = SumElem(numM,numN);
System.Console.WriteLine(resultSum);
}
else {System.Console.WriteLine("Введены некоректные числа");}

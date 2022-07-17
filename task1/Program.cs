// Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNum(int n, int k)
{
    if (k > n)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return;
    }
    
    System.Console.Write($"{k} ");
    PrintNum(n,k+2);
    //System.Console.WriteLine(k);
}

int n = Promt("Введите натуральное число ");
int k = 2;
PrintNum(n,k);
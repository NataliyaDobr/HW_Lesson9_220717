// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int AckermanFun(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFun(m - 1, 1);
  else return AckermanFun(m - 1, AckermanFun(m, n - 1));
}

int M = Promt("Ввведите число M ");
int N = Promt("Ввведите число N ");

int result = AckermanFun(M,N);

System.Console.WriteLine(result);
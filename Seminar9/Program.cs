//                                                          Практическое задание по семинару 9

//                                                                      Задача 66

Console.Clear();

int SumFromMToN(int m, int n)
{
    if (n == m)
        return n;
    return SumFromMToN(m,n - 1) + n;
}

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumFromMToN(m,n));

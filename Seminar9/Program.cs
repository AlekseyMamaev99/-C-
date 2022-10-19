//                                                          Практическое задание по семинару 9

//                                                                      Задача 66

// Console.Clear();

// int SumFromMToN(int m, int n)
// {
//     if (n == m)
//         return n;
//     return SumFromMToN(m,n - 1) + n;
// }

// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumFromMToN(m,n));


//                                                                      Задача 68

// Console.Clear();

// int AkkermanF(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (n == 0)
//         return AkkermanF(m - 1,1);
//     return AkkermanF(m - 1, AkkermanF(m,n - 1));
    
// }
// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// if (m < 0 || n < 0)
//     Console.WriteLine("Введите неотрицательные числа!");
// else
//     Console.WriteLine("Вычесление по функции Аккермана = " + AkkermanF(m,n));

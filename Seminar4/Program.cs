//                                                        Практическая работа по семинару 4

//                                                                      Задача 25


// Console.WriteLine("Введите чило: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень чила: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= b; i++)
// {
//     result = result * a;
// }
// Console.WriteLine(result);

//                                                                      Задача 27

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
string m = Convert.ToString(n);

for (int i = 0; i < m.Length; i++)
{
    int x = Convert.ToInt32(Convert.ToString(m[i]));
    sum =sum + x;
}
Console.WriteLine(sum);


//                                                                      Задача 29

// int[] array = new int[8];
// Console.WriteLine("Введите первое число: ");
// array[0] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// array[1] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третие число: ");
// array[2] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите четвертое число: ");
// array[3] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите пятое число: ");
// array[4] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите шестое число: ");
// array[5] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите седьмое число: ");
// array[6] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите восьмое число: ");
// array[7] = Convert.ToInt32(Console.ReadLine());


// Console.Write("[" + string.Join(",", array) + "]");

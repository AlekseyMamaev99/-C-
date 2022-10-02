//                                                         Практическое задание по 5 семинару

//                                                                      Задача 34

// Console.Clear();

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }

// int ChetnyeCount(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Введите кол-во обьектов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// InputArray(array);
// Console.WriteLine($"[" + string.Join(",", array) + "]");

// Console.WriteLine(ChetnyeCount(array));




//                                                                      Задача 36




// Console.Clear();

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100,101);
//     }
// }

// int SumNeChetnyh(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Введите кол-во обьектов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// InputArray(array);
// Console.WriteLine($"[" + string.Join(",", array) + "]");

// Console.WriteLine(SumNeChetnyh(array));


//                                                                      Задача 38



// Console.Clear();

// void InputArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().NextDouble() * 10;
//     }
// }

// double MaxMinRaznitca(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     double raznitca = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         while (array[i] > max)
//         {
//             max = array[i];
            
//         }

//         while (array[i] < min)
//         {
//             min = array[i];
            
//         }

//         raznitca = max - min;

//     }
//     return raznitca;

// }


// Console.WriteLine("Введите кол-во обьектов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];

// InputArray(array);
// Console.WriteLine($"[" + string.Join(",  ", array) + "]");

// Console.WriteLine(MaxMinRaznitca(array));

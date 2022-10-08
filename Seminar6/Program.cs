//                                                         Практическая работа по 6 семинару

//                                                                      Задача 41

// Console.Clear();

// Console.WriteLine("Введите нужное количество элементов массива :");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine($"Введите {i + 1} элемент массива: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }


// int CountBolsheZero(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }

// Console.WriteLine($"[" + String.Join("; ", array) + "]");
// Console.WriteLine();
// CountBolsheZero(array);
// Console.WriteLine($"Элементов > 0 = [{CountBolsheZero(array)}]");



//                                                                      Задача 43



// Console.Clear();

// Console.WriteLine("Введите переменную b1 :");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную k1 :");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите переменную b2 :");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную k2 :");
// double k2 = Convert.ToInt32(Console.ReadLine());


// if (k1 != k2)
// {   
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
// }
// else if (k1 == k2 && b1 == b2)
// {
//     Console.WriteLine("Это одна и та же прямая!");
// }
// else if (k1 == k2)
// {
//     Console.WriteLine("Эти прямые паралелльны!");
// }



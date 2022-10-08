//                                                          Практическая работа по семинару 7

//                                                                      Задача 47

// Console.Clear();

// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().NextDouble() *10;
//             Console.Write(matrix[i,j] + "\t");
//         }
//     }
// }

// int m = 3;
// int n = 4;

// double[,] matrix = new double[n,m];
// InputMatrix(matrix);

//                                                                      Задача 50

// Console.Clear();

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(-10,11);
//             Console.Write(matrix[i,j] + "\t");
        
//         }
//     Console.WriteLine();
//     }
    
// }

// int n = 4;
// int m = 4;

// int[,] matrix = new int[n,m];
// InputMatrix(matrix);

// Console.WriteLine("Введите номер строки: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x <= 0 || y <= 0)
// {
//     Console.WriteLine("Такого элемента не существует");
// }
// else if (x <= n + 1 && y <= m + 1)
// {
//     n = x - 1;
//     m = y - 1;
//     Console.WriteLine($"Вы искали элемент: " + matrix[n , m]);
// }
// else if (x > n +1 || y > m +1 )
// {
//     Console.WriteLine("Такого элемента не существует");
// }


//                                                                      Задача 52



// Console.Clear();

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(-10,11);
//             Console.Write(matrix[i,j] + "\t");
        
//         }
//     Console.WriteLine();
//     }
    
// }

// Console.WriteLine("Введите количество строк : ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов : ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] matrix = new int[n,m];
// InputMatrix(matrix);

// double sum = 0;

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum = sum + matrix[i,j];
        
//     }
//     double srednee = sum / n;
//     Console.WriteLine(srednee);
    
// }


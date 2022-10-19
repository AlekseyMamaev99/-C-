//                                                          Практическая работа по 8 семинару

//                                                                      Задача 54


// Console.Clear();

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,11);
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
    
// Console.WriteLine("Введите количество строк : ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов : ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] matrix = new int[n,m];
// InputMatrix(matrix);

// void fromMaxToMin(int[,] matrix)
// {
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
            
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
                
            
//                 if (matrix[i , k ] < matrix[i,k + 1])
//                 {
//                     int znachenie = matrix[i,k];
//                     matrix[i,k] = matrix[i ,k + 1];
//                     matrix[i , k + 1] = znachenie;
                    
//                 }
            
//             }   
        

//          Console.Write(matrix[i,j] + "\t");
//         }
        
//      Console.WriteLine();
//     }
    
// }
// Console.WriteLine();
// fromMaxToMin(matrix);

//                                                                      Задача 56



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
//         Console.WriteLine();
//     }
// }
    

// Console.WriteLine("Введите количество строк : ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов : ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] matrix = new int[n,m];
// InputMatrix(matrix);

// int minSummaStroki(int[,] matrix)
// {
//     int index = 0;
    
//     int minSumma = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             sum = sum + matrix[i,j];
//         }
//         if (minSumma > sum)
//         {
//             minSumma = sum;
//             index = i;
//         }
       
//     }
//     return index; 
// }

// minSummaStroki(matrix);
// Console.Write("Минимальная сумма в строке №: ");
// Console.WriteLine(minSummaStroki(matrix) + 1 );


//                                                                      Задача 58



// Console.Clear();

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,11);
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
    

// void ProizvedenieMatrix(int[,] matrixOne, int[,] matrixTwo)
// {
//     int[,] resultMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];

//     for (int i = 0; i < matrixOne.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixOne.GetLength(1); j++)
//         {
//             resultMatrix[i,j] = matrixOne[i,j] * matrixTwo[i,j];
//             Console.Write(resultMatrix[i,j] + " ");
//         }
//     Console.WriteLine();
//     } 
// }

// Console.WriteLine("Введите количество строк : ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов : ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] matrixOne = new int[n,m];
// int[,] matrixTwo = new int[n,m];

// Console.WriteLine("Начальная матрица 1: ");
// InputMatrix(matrixOne);
// Console.WriteLine("Начальная матрица 2: ");
// InputMatrix(matrixTwo);
// Console.WriteLine("Произведение матриц : ");
// ProizvedenieMatrix(matrixOne, matrixTwo);

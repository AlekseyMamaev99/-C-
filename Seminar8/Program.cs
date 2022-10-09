//                                                          Практическая работа по 8 семинару

//                                                                      Задача 54


Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,11);
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
    
Console.WriteLine("Введите количество строк : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[n,m];
InputMatrix(matrix);

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


int[,] otMaxKMin(int[,] matrix)
{
    int[,] array = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int[] miniArr = new int[matrix.GetLength(1)];
            miniArr[j] = matrix[i,j];
            for (int k = 0; k < miniArr.Length - 1 ; k++)
            {
                if (miniArr[j] < miniArr[j + 1])
                {
                    int temp = miniArr[j];
                    miniArr[j] = miniArr[j + 1];
                    miniArr[j + 1] = temp;
                }
                
            }
            array[i,j] = miniArr[j];
        }
    }
    return array;
}
otMaxKMin(matrix);
Console.Write(otMaxKMin(matrix));

//                                                         Практическая работа по 6 семинару

//                                                                      Задача 41

Console.Clear();

Console.WriteLine("Введите нужное количество элементов массива :");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}


int CountBolsheZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.WriteLine($"[" + String.Join("; ", array) + "]");
Console.WriteLine();
CountBolsheZero(array);
Console.WriteLine($"Элементов > 0 = [{CountBolsheZero(array)}]");


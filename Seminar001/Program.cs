// Домашняя работа по семинару №1.

// Задача 2

// int a = 5;
// int b = 7;

// if (a > b )
// {
//     Console.Write("max = ");
//     Console.Write(a);
// }
// else
// {
//     Console.Write("max = ");
//     Console.Write(b);
// }


// Задача 4

int a = 44;
int b = 5;
int c = 78;

int max = a;

if (b > a && b > c)
{
     max = b;
}
else if (c > a && c > b)
{
     max = c;
}
else
{
     max = a;
}

Console.WriteLine(max);
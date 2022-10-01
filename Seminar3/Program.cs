//                                                          Практическое задание по семинару 3
//                                                                      Задача 19

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

string txt = Convert.ToString(n);

if (n < 10000 || n >= 100000 )
    Console.WriteLine("Это не пятизначное число! Попробуйте снова!");

else if (txt [0] == txt [4] && txt [1] == txt [3])
    Console.WriteLine("Это число полиндром!");
        
else 
    Console.WriteLine("НЕ полиндром");
        


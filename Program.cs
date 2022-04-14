//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число: ");
string num_1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string num_2 = Console.ReadLine();
if (Convert.ToInt32(num_1) > Convert.ToInt32(num_2))
    Console.Write($"Максимальное число: {num_1}, Минимальное число: {num_2}");
else
    Console.Write($"Максимальное число: {num_2}, Минимальное число: {num_1}");
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int test = Convert.ToInt32(2);


if (number % test == 0)
    Console.WriteLine(number + " кратно 2");
else 
Console.WriteLine(number + " не делится на 2 без остатка");

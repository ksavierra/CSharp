// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int test = Convert.ToInt32(2);


for (int i = 1; i <= number; i++)
{
    if (i % test == 0)
        Console.WriteLine(i);
       
    
}



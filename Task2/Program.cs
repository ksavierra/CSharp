// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
   Console.Write("max = " + number_1 + ", min = " + number_2);
   
else if (number_1 < number_2)
   Console.Write("max = " + number_2 + ", min = " + number_1);
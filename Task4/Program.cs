// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

var array = new int[] {number_1, number_2, number_3};
Console.WriteLine(array.Max());



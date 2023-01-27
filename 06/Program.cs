//Напишите программу, которая определяет, четоное это число, или нет.
Console.WriteLine("Введите число для проверки");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write("Данное число является четным");
else Console.Write("Данное число является нечетным");
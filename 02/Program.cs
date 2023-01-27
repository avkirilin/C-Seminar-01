//Введите 2 любых целых числа. Определите, какое из них наибольшее, а какое наименьшее
Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum > secondNum)
{
    Console.WriteLine($"Наибольшее из двух чисел: {firstNum}");
    Console.WriteLine($"Наименьшее из двух чисел: {secondNum}");
}
else
{
    Console.WriteLine($"Наибольшее из двух чисел: {secondNum}");
    Console.WriteLine($"Наименьшее из двух чисел: {firstNum}");
}
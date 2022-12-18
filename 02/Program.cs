Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum > secondNum)
{
    Console.Write("Наибольшее из двух чисел: ");
    Console.WriteLine(firstNum);
    Console.Write("Наименьшее из двух чисел: ");
    Console.Write(secondNum);
}
else
{
    Console.Write("Наибольшее из двух чисел: ");
    Console.WriteLine(secondNum);
    Console.Write("Наименьшее из двух чисел: ");
    Console.Write(firstNum);
}
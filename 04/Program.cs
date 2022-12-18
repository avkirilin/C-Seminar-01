Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdNum = Convert.ToInt32(Console.ReadLine());
int max = firstNum;
if (max < secondNum)
{
    max = secondNum;
}
else
{
    
}
if (max < thirdNum)
{
    max = thirdNum;
}
Console.Write("Наибольшее из трех чисел: ");
Console.WriteLine(max);
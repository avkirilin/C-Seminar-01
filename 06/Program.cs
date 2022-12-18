Console.WriteLine("Введите число для проверки");
int A = Convert.ToInt32(Console.ReadLine());

if (A % 2 == 0)
{
    Console.Write("Данное число является четным");
}
else
{
    Console.Write("Данное число является нечетным");
}
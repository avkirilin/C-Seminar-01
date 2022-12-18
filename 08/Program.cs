Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int A = 1;
Console.Write("Все четные числа от 1 до ");
Console.WriteLine(N);
while (A < N + 1)
{
    if (A % 2 == 0)
    {
        Console.Write(A);
        Console.Write(", ");
    }
    else
    {

    }
    A = A + 1;
}

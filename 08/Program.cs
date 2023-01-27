//Задайте любое положительное целое число. Выведите все четные числа от 0 до этого числа, не включая его самого
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Все четные числа от 1 до {n}: ");
for (int a = 0; a < n; a = a + 2)
{
    if (a % 2 == 0)
    {
        if (a == n || a == n - 1 || a == n - 2) Console.Write($"{a}");
        if (a < n - 3) Console.Write($"{a}, ");
    }

}

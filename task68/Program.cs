// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int M = UserInput("Введите m: ");
int N = UserInput("Введите n: ");
Console.WriteLine($"A({M}, {N}) = {AckermannFunction(M, N)}");

int UserInput(string message)
{
    Console.WriteLine(message);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }

}
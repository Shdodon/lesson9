// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int M = UserInput("Введите M: ");
int N = UserInput("Введите N: ");
ListElements(M, N);

Console.WriteLine($"M = {M}; N = {N} -> {ListElements(M, N)}");

int UserInput(string message)
{
    Console.WriteLine(message);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}

int ListElements(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        return numberM;
    }
    else
    {

        return numberM + ListElements(numberM + 1, numberN);
    }

}
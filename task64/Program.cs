// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();

int temp = UserInput("Введите N");
// VoidListElements(temp); вызов void метода
IntListElements(temp);


int UserInput(string message)
{
    int N = int.Parse(Console.ReadLine());
    Console.Write($"N = {N} -> ");
    return N;
}


/* void метод
void VoidListElements(int userInput)
{
    if (userInput > 1)
    {
        Console.Write($"{userInput}, ");
    }
    else
    {
        Console.Write($"{userInput}");
    }
    if (userInput == 1)
    {
        return;
    }
    else
    {
        VoidListElements(userInput - 1);
    }
}
*/

// int метод
int IntListElements(int userInput)
{
    if (userInput > 1)
    {
        Console.Write($"{userInput}, ");
    }
    else
    {
        Console.Write($"{userInput}");
    }
    if (userInput == 1)
    {
        return 1;
    }
    else
    {
        return IntListElements(userInput - 1);
    }
}
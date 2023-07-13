// Задача 23: Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void GetCubes(int number)
{
    int X = 1;

    while (X <= number)
    {
        if (X == number)
        {
            Console.Write($"{Math.Pow(X, 3)}");
        }
        else
        {
            Console.Write($"{Math.Pow(X, 3) + ", "}");
        }
        X++;
    }
}

int N = Prompt("Введите число: ");
GetCubes(N);

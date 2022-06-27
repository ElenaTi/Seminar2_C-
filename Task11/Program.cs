int GetRandomNumber(int minBorder, int maxBorder)
{
    return new Random().Next(minBorder, maxBorder + 1);
}

int result (int number)
{
    int NumberFirst = number / 100;
    int NumberThird = number % 100;
    int newNumber = (NumberFirst*10) + NumberThird;
    return newNumber;
}

int randomNumber = GetRandomNumber(100, 999);
int Digit = result(randomNumber);
Console.WriteLine($"Случайное число {randomNumber} преобразуем в {Digit}");
//Console.WriteLine($"Случайное число {randomNumber} преобразуем в {Digit}");

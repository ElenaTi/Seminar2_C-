// Вывести третью цифру числа или ссобщить, что цифры нет
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int GetThirdDigit(int digit)
{
    int digitThree = digit % 10;
    return digitThree;
}

if (number > 999)
{
    int number1 = number;
    while (number1 > 999)
    {
       number1 = number1/10;
    }
    int ThreeDigitNumber = number1;
    int digitThree1 = GetThirdDigit(ThreeDigitNumber);
    Console.WriteLine($"В числе {number} третья цифра {digitThree1}.");
}
else if (number > 99 && number <1000)
{
    int digitThree = GetThirdDigit(number);
    Console.WriteLine($"В числе {number} третья цифра {digitThree}.");
}
else
{
    Console.WriteLine($"В числе {number} третьей цифры нет.");
}

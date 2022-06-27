// принимает на вход трехзначное число, на выходе показывает вторую цифру.
Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

int result (int number)
{
    int NumberFirst = number % 100;
    int NumberSecond = NumberFirst / 10;
    
    return NumberSecond;
}

if (number1 < 1000 && number1 > 99)
{
    int Digit = result(number1);
    Console.WriteLine($"Вторая цифра от введенного числа {number1} - это {Digit}.");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}
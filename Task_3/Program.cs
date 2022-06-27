Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
    Console.WriteLine($"Первое введенное число {number1} кратно второму введенному числу {number2}.");
}
else
{
    Console.WriteLine($"Первое введенное число {number1} не кратно второму введенному числу {number2}. Остаток от деления {number1 % number2}.");
}
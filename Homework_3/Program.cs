//Принимает на вход цифру, обозначающую день недели. Проверяет, является ли выходным.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 5 && number < 8)
{
    Console.WriteLine("Да, это выходной день.");
}
else if (number >0 && number < 6)
{
    Console.WriteLine("Нет, это рабочий день.");
}
else
{
    Console.WriteLine("Нет дня недели, соответствующего этому числу.");
}
Console.Write("Веди число: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23.");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23.");
}

Console.WriteLine("Введите любое число");
int Num1 = int.Parse(Console.ReadLine()??"0");

if ((Num1%7 == 0) && (Num1%23 == 0))
{
    Console.WriteLine("Делится");
}
else
{
    Console.WriteLine("Не делится");
}
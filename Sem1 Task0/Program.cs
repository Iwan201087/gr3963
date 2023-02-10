// Считываем из консоли
string? inputNum = Console.ReadLine ();
// Проверяем, что данные не путые
if (inputNum != null)
{
    //Парсим введенное число
    int number = int.Parse(inputNum);
    // находим квадрат числа
    int outNum = (int)Math.Pow(number,2);
    Console.WriteLine("квадрат числа: ",+outNum);
}
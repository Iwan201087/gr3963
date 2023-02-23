//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Описание метода ReadData для чтения входных данных  от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Описание void метода LineBuilder для вывода в строку значений чисел в степени 
void LineBuilder(int end, int pow)
{
    string res = String.Empty;// сначала переменной res присваиваем пустую строку
    for(int i = 1; i<=end; i++)
    {
        Console.Write($"{Math.Pow(i,pow)}\t");// возведение в степень, вывод с учетом табуляции
    }
    Console.WriteLine();
}
int N = ReadData("Введите конечное число: "); // вызов метода ReadData ввода конечного числа, до которого идет подсчет
LineBuilder(N,1); // Вызов void метода LineBuilder для вывода в строку значений чисел до N в первой степени
LineBuilder(N,3); // Вызов void метода LineBuilder для вывода в строку значений чисел до N в третьей степени